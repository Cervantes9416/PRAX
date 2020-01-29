using PRAXYS.Business.Interfaces;
using PRAXYS.Commons.Entities.PaymentType;
using PRAXYS.Data.Intefaces;
using PRAXYS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PRAXYS.Data.DALC;
using PRAXYS.Data;
using AutoMapper;
using PRAXYS.Commons.Entities.BondPayment;

namespace PRAXYS.Business
{
    public class PaymentTypeBLC : IPaymentTypeBLC
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public PaymentTypeBLC(AppDbContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public Task<PaymentTypeModel> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletePayment(int id)
        {
            return _context.PaymentTypeDelete(id);
        }

        public async Task<PaymentTypeModel> Get(int id)
        {
            var paymentType = await _context.PaymentTypeGet(id);
            return _mapper.Map<PaymentTypeModel>(paymentType);
        }

        public async Task<List<PaymentTypeModel>> GetAll()
        {
            var payments = await _context.PaymentTypeGetAll();
            return _mapper.Map<List<PaymentTypeModel>>(payments);
        }

        public async Task<PaymentTypeModel> Post(PaymentTypeModel item)
        {
            var paymentType = _mapper.Map<PaymentType>(item);
            await _context.PaymentTypePost(paymentType);
            return item;
        }

        public Task<bool> Post(BondPaymentModel item)
        {
            throw new NotImplementedException();
        }

        public Task<PaymentTypeModel> Put(int id, PaymentTypeModel item)
        {
            throw new NotImplementedException();
        }
    }
}
