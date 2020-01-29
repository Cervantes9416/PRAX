using PRAXYS.Business.Interfaces;
using PRAXYS.Data;
using PRAXYS.Data.DALC;
using PRAXYS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using PRAXYS.Commons.Entities.BondPayment;
using PRAXYS.Commons.Entities.PaymentInformation;
using AutoMapper;

namespace PRAXYS.Business
{
    public class PaymentInformationBLC : IPaymentInformation
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public PaymentInformationBLC(AppDbContext context,IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public Task<PaymentInformation> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<PaymentInformation> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<PaymentInformation>> GetAll()
        {
            return await _context.GetAllPayments();
        }

        public async Task<List<PaymentInformation>> GetAllPaymentsWithInsurancceID()
        {
            return await _context.GetAllPaymentsWithInsuranceID();
        }

        public async Task<List<PaymentInformationModel>> GetAllInsurancePayments(int id)
        {
            var insurance = await _context.InsuranceGet(id); 
            var payments = await _context.PaymentInformationGetAllWithInsuranceNumber(insurance.InsuranceNumber);

            return _mapper.Map<List<PaymentInformationModel>>(payments);
        }

        public Task<PaymentInformation> Post(PaymentInformation item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Post(BondPaymentModel item)
        {
            throw new NotImplementedException();
        }

        public Task<PaymentInformation> Put(int id, PaymentInformation item)
        {
            throw new NotImplementedException();
        }
    }
}
