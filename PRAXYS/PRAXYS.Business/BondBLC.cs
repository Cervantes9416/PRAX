using PRAXYS.Data;
using PRAXYS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PRAXYS.Data.DALC;
using AutoMapper;
using PRAXYS.Commons.Entities.Bond;
using PRAXYS.Business.Interfaces;

namespace PRAXYS.Business
{
    public class BondBLC : IBondBLC
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public BondBLC(AppDbContext context,IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public async Task<List<BondListModel>> GetAll()
        {
            var bonds = await _context.GetAllBondsWithDetails();
            return _mapper.Map<List<BondListModel>>(bonds);
        }

        public async Task<BondModel> Get(int id)
        {
            var bond = await _context.BondGet(id);
            return _mapper.Map<BondModel>(bond);
        }

        public async Task<BondModel> GetWithDetails(int id)
        {
            var bond = await _context.BondGetWithDetails(id);
            return _mapper.Map<BondModel>(bond);
        }

        public async Task<BondModel> Post(BondModel model)
        {
            //using (var transaction = _context.Database.BeginTransaction())
            //{
                try
                {
                    var item = _mapper.Map<Bond>(model);
                    item.Agent = null;
                    
                    //CREAR FIANZA
                    var result = await _context.BondPost(item);

                    //transaction.Commit();
                    return model;
                }
                catch (Exception)
                {
                    //transaction.Rollback();
                    return null;
                }
            //}           
        }
    }
}
