using AutoMapper;
using PRAXYS.Commons.Entities.Endorsement;
using PRAXYS.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PRAXYS.Data.DALC;
using PRAXYS.Shared.Entities;
using PRAXYS.Business.Interfaces;
using System.Transactions;
using PRAXYS.Data.Intefaces;
using PRAXYS.Commons.Enum;

namespace PRAXYS.Business
{
    public class EndorsementBLC : IEndorsementBLC
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public EndorsementBLC(AppDbContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public async Task<bool> CreateEndorsement(EndorsementModel model)
        {
            using (var transaction = _context.Database.BeginTransaction() )
            {
                try
                {
                    //Creando Poliza con la informacion del Endoso
                    var insurance = _mapper.Map<Insurance>(model);
                    var TotalEndorsement = await _context.EndorsementWithInsuranceNumber(insurance.InsuranceNumber);
                    var EndorsementNumber = TotalEndorsement.Count + 1;

                    insurance.SubAgentID = model.Insurance.SubAgentID;
                    insurance.SubBranchID = model.Insurance.SubBranchID;
                    insurance.Endorsement = true;
                    insurance.EndorsementNumber = EndorsementNumber;
                    insurance.Status = (int)InsuranceStatus.Valid;

                    int totalpayments = (model.TotalPremium != model.FirstPayment.TotalPremium) ? insurance.PaymentType.TotalPayments : 1;
                    insurance.PaymentType = null;

                    //Crear primer pago
                    insurance.Payments = new List<PaymentInformation>();
                    insurance.Payments.Add(
                            new PaymentInformation()
                            {
                                IssueDate = DateTime.Today,
                                PaymentNumber = $"001/00{totalpayments}",
                                Premium = model.FirstPayment.TotalPremium,
                                PaymentExpirationDate = DateTime.Today.AddMonths(1),
                                InsuranceID = insurance.ID,
                            }
                        );

                    //Crear Pagos Subsecuentes
                    //Si el pago del primer recibo es diferente de la prima neta total, el monto restante se
                    //dividira entre los pagos subsecuentes
                    if (model.TotalPremium != model.FirstPayment.TotalPremium)
                    {
                        var PremiumPerPayment = (insurance.TotalPremium - model.FirstPayment.TotalPremium) / totalpayments - 1;

                        for (int i = 1; i < totalpayments; i++)
                        {
                            insurance.Payments.Add(
                                 new PaymentInformation()
                                 {
                                     IssueDate = DateTime.Today,
                                     PaymentNumber = $"00{i + 1}/00{totalpayments}",
                                     Premium = PremiumPerPayment,
                                     PaymentExpirationDate = DateTime.Today.AddDays(15),
                                     InsuranceID = insurance.ID,
                                 }
                             );
                        }
                    }
                    
                    var newInsurance = await _context.InsurancePost(insurance);

                    //Crear Endoso
                    var endorsement = _mapper.Map<Endorsement>(model);
                    endorsement.InsuranceID = newInsurance.ID;
                    endorsement.Insurance = null;

                    var result = await _context.EndorsementCreate(endorsement);

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

        public async Task<bool> CreateEndorsementModification(ModificationEndorsementRequest model)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    //Creando poliza con la informacion del Endoso
                    var insurance = _mapper.Map<Insurance>(model.Endorsement);
                    var TotalEndorsement = await _context.EndorsementWithInsuranceNumber(insurance.InsuranceNumber);
                    var EndorsementNumber = TotalEndorsement.Count + 1;

                    insurance.SubAgentID = model.Insurance.SubAgentID;
                    insurance.SubBranchID = model.Insurance.SubBranchID;
                    insurance.Endorsement = true;
                    insurance.EndorsementNumber = EndorsementNumber;
                    insurance.Status = (int)InsuranceStatus.Valid;

                    var newInsurance = await _context.InsurancePost(insurance);

                    //Actualizar datos de la poliza
                    var insuranceEdited = _mapper.Map<Insurance>(model.Insurance);
                    await _context.InsurancePut(insuranceEdited.ID, insuranceEdited);

                    //Crear Endoso
                    var endorsement = _mapper.Map<Endorsement>(model.Endorsement);
                    endorsement.InsuranceID = newInsurance.ID;
                    endorsement.Insurance = null;

                    var result = await _context.EndorsementCreate(endorsement);
                    
                    transaction.Commit();
                    return true;
                }
                catch (Exception)
                {

                    transaction.Rollback();
                    return false;
                }
            }
        }


        public async Task<EndorsementModel> GetEndorsement(int id)
        {
            return null;
        }

        public async Task<EndorsementModel> GetAllEndorsement(int id)
        {
            return null;
        }

        public async Task<bool> DeleteEndorsement(int id)
        {
            var result = await _context.EndorsementDelete(id);
            return true;
        }

        #region ENDORSEMENT TYPE METHODS
        public async Task<List<EndorsementTypeModel>> GetAllEndorsementType()
        {
            var endorsements = await _context.EndorsementTypeGetAll();
            return _mapper.Map<List<EndorsementTypeModel>>(endorsements);
        }

        #endregion
    }
}
