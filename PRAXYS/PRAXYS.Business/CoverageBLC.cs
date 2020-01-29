using PRAXYS.Business.Interfaces;
using PRAXYS.Commons.Entities.BondPayment;
using PRAXYS.Data.Intefaces;
using PRAXYS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PRAXYS.Business
{
    public class CoverageBLC : ICoverageBLC
    {
        private ICoverageDALC _coverageDALC;

        public CoverageBLC(ICoverageDALC coverageDALC)
        {
            this._coverageDALC = coverageDALC;
        }

        public Task<Coverage> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Coverage> Get(int id)
        {
            return await _coverageDALC.Get(id);
        }

        public async Task<List<Coverage>> GetAll()
        {
            return await _coverageDALC.GetAll();
        }

        public async Task<List<Coverage>> GetAllByDeatils()
        {
            return await _coverageDALC.GetAllByDeatils();
        }

        public async Task<List<Coverage>> GetCoverageByRamo(int RamoID)
        {
            return await _coverageDALC.GetCoverageByRamo(RamoID);
        }

        public async Task<Coverage> Post(Coverage item)
        {
            return await _coverageDALC.Post(item);
        }

        public Task<bool> Post(BondPaymentModel item)
        {
            throw new NotImplementedException();
        }

        public Task<Coverage> Put(int id, Coverage item)
        {
            throw new NotImplementedException();
        }
    }
}
