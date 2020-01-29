using AutoMapper;
using PRAXYS.Business.Helpers;
using PRAXYS.Business.Interfaces;
using PRAXYS.Commons.Entities;
using PRAXYS.Commons.Entities.Insurance;
using PRAXYS.Data.Intefaces;
using PRAXYS.Data.DALC;
using PRAXYS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRAXYS.Data;
using System.Transactions;
using PRAXYS.Commons.Entities.BondPayment;
using PRAXYS.Commons.Enum;

namespace PRAXYS.Business
{
    public class InsuranceBLC : IInsuranceBLC
    {
        private IMapper _mapper;
        private AppDbContext _context;

        public InsuranceBLC(AppDbContext context, IMapper mapper)
        {
            this._mapper = mapper;
            this._context = context;
        }

        public async Task<Insurance> Delete(int id)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var endorsement = await _context.EndorsementGetWithInsuranceID(id);
                    if(endorsement != null)
                    {
                        await _context.EndorsementDelete(endorsement.ID);
                    }

                    var insurance = await _context.InsuranceDelete(id);

                    transaction.Commit();
                    return insurance;
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    return null;
                    throw;
                }
            }
        }

        public async Task<Insurance> Get(int id)
        {
            return await _context.InsuranceGet(id);
        }

        public async Task<Insurance> GetByDetails(int id)
        {
            return await _context.InsuranceGetByDetails(id);
        }

        public async Task<List<Insurance>> GetAll()
        {
            return await _context.InsuranceGetAll();
        }

        public async Task<List<Insurance>> GetAllByClientID(int id)
        {
            return await _context.InsuranceGetAllByClientID(id);
        }

        public async Task<List<Insurance>> GetAllByAgentID(int id)
        {
            return await _context.InsuranceGetAllByAgentID(id);
        }

        public async Task<List<Insurance>> GetAllByCompanyID(int id)
        {
            return await _context.InsuranceGetAllByCompanyID(id);
        }

        public async Task<List<Insurance>> GetAllBySubAgentID(int id)
        {
            return await _context.InsuranceGetAllBySubAgentID(id);
        }

        public async Task<List<Insurance>> GetAllByDetails()
        {
            var insurances = await _context.InsuranceGetAllByDetails();

            var result = _mapper.Map<List<InsuranceListModel>>(insurances);

            return insurances;
        }

        public async Task<List<InsuranceEndorsementModel>> GetAllWithInsuranceNumber(string insuranceNumber)
        {
            //var insurances = await _context.InsuranceGetAllWithInsuranceNumber(insuranceNumber);
            var insurances = await _context.InsuranceGetAllWithEndorsement(insuranceNumber);

            return _mapper.Map<List<InsuranceEndorsementModel>>(insurances);
        }

        public async Task<List<InsuranceListModel>> GetAllWithoutEndorsement()
        {
            var insurances = await _context.InsuranceGetAllWithoutEndorsement();
            return _mapper.Map<List<InsuranceListModel>>(insurances);
        }

        public Task<List<Insurance>> GetAllNextToExpire(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Insurance>> GetAllByFilter(InsuranceFilter filter)
        {
            return await _context.InsuranceGetAllByFilter(filter);
        }

        public async Task<List<InsuranceCardModel>> GetInsuranceNextToExpire(DatePickerModel datePickerModel)
        {
            var insurances = await _context.InsuranceGetNextToExpire(datePickerModel);
            return insurances
                .GroupBy(x => x.Company.CompanyName)
                .Select(x => new InsuranceCardModel { Company = x.Key, TotalInsruances = x.Count() })
                .ToList();
        }

        public async Task<Insurance> Post(Insurance item)
        {
            using (var transs = _context.Database.BeginTransaction())
            {
            
                try
                {
                    var TotalPayments = item.PaymentType.TotalPayments;
                    var PremiumPerPayment = item.TotalPremium / TotalPayments;
                    var company = await _context.CompanyGet(item.CompanyID);
                    DateTime? currentDate = null;

                    //----------DEFINIR PAGOS
                    item.Status = (int)InsuranceStatus.Valid;
                    item.Payments = item.Payments == null ? new List<PaymentInformation>() : item.Payments;

                    for (int i = 0; i < TotalPayments; i++)
                    {
                        item.Payments.Add(
                            new PaymentInformation()
                            {
                                IssueDate = DateTime.Today,
                                PaymentNumber = $"{i + 1}/{TotalPayments}",
                                Premium = PremiumPerPayment,
                            }
                        );
                    }

                    //----------DEFINIR LAS FECHAS LIMITES DE PAGO
                    foreach (var payment in item.Payments)
                    {
                        if (payment.PaymentNumber.Contains("1/"))
                        {
                            payment.PaymentExpirationDate = item.ValidFrom.Value.AddDays(company.Days_Payment_First_Recibe_New);
                        }
                        else
                        {
                            payment.PaymentExpirationDate = currentDate.Value.AddDays(15);
                        }

                        currentDate = payment.PaymentExpirationDate;
                    }

                    item.PaymentType = null;
                    var insurance = await _context.InsurancePost(item);

                    transs.Commit();
                    return insurance;
                }
                catch (Exception e)
                {
                    transs.Rollback();
                    return null;
                }
            }
        }

        public async Task<bool> CancelInsurance(InsuranceModel insurance)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    //------- CANCELAR POLIZAS
                    //var insurance = await _context.InsuranceGet(id);
                    var insurances = await _context
                        .InsuranceGetAllWithInsuranceNumber(insurance.InsuranceNumber);

                    foreach (var item in insurances)
                    {
                        item.Status = (int)InsuranceStatus.Cancelled;
                        await _context.InsurancePut(insurance.ID, item);
                    }

                    //------- CANCELAR PAGOS
                    var payments = await _context
                        .PaymentInformationGetAllWithInsuranceNumber(insurance.InsuranceNumber);
                    foreach (var item in payments)
                    {
                        item.Canceled = true;
                        await _context.PaymentInformationUpdate(item);
                    }

                    transaction.Commit();
                    return true;
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    return false;
                }
            }
        }

        public async Task<Insurance> Put(int id, Insurance item)
        {
            return await _context.InsurancePut(id, item);
        }

        public Task<bool> Post(BondPaymentModel item)
        {
            throw new NotImplementedException();
        }
    }
}
