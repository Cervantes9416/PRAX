using AutoMapper;
using PRAXYS.Business.Interfaces;
using PRAXYS.Commons.Entities.BondPayment;
using PRAXYS.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PRAXYS.Data.DALC;
using PRAXYS.Shared.Entities;

namespace PRAXYS.Business
{
    public class BondPaymentBLC : IBondPayment
    {
        private IMapper _mapper;
        private AppDbContext _context;

        public BondPaymentBLC(AppDbContext context, IMapper mapper)
        {
            this._mapper = mapper;
            this._context = context;
        }

        public Task<BondPaymentModel> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<BondPaymentModel> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<BondPaymentModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Post(BondPaymentModel item)
        {
            item.DateCreated = DateTime.Today;
            item.DateEdited = DateTime.Today;

            var bondPayment = _mapper.Map<BondPayment>(item);
            return await _context.BondPaymentCreate(bondPayment);
        }

        public Task<BondPaymentModel> Put(int id, BondPaymentModel item)
        {
            throw new NotImplementedException();
        }

        Task<BondPaymentModel> IGenericBLC<BondPaymentModel>.Post(BondPaymentModel item)
        {
            throw new NotImplementedException();
        }
    }
}
