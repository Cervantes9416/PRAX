using PRAXYS.Business.Interfaces;
using PRAXYS.Commons.Entities.ComissionPayment;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PRAXYS.Data.DALC;
using PRAXYS.Data;
using AutoMapper;
using PRAXYS.Shared.Entities;
using PRAXYS.Commons.Entities.BondPayment;

namespace PRAXYS.Business
{
    public class ComissionPaymentBLC : IComissionPaymentBLC
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public ComissionPaymentBLC(AppDbContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public Task<ComissionPaymentModel> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ComissionPaymentModel> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ComissionPaymentModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> CreateComissionPayment(ComissionPaymentModel item)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    item.DateCrated = DateTime.Today;
                    item.DateEdited = DateTime.Today;
                    var comission = _mapper.Map<CommissionPayment>(item);

                    if (await _context.ComissionPaymentCreate(comission))
                    {
                        var result = await _context.BondPaymentGet(item.BondPaymentID);
                        result.CommissionPayed = true;
                        await _context.BondPaymentUpdate(result);
                    }

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

        public Task<ComissionPaymentModel> Post(ComissionPaymentModel item)
        {
            throw new NotImplementedException();
        }

        public Task<ComissionPaymentModel> Put(int id, ComissionPaymentModel item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Post(BondPaymentModel item)
        {
            throw new NotImplementedException();
        }
    }
}
