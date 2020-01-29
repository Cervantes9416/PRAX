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
    public class CoveragePlanBLC : ICoveragePlanBLC
    {
        private ICoveragePlanDALC _coveragePlanDALC;

        public CoveragePlanBLC(ICoveragePlanDALC coveragePlanDALC)
        {
            this._coveragePlanDALC = coveragePlanDALC;
        }

        public Task<CoveragePlan> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CoveragePlan> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CoveragePlan>> GetAll()
        {
            return await _coveragePlanDALC.GetAll();
        }

        public async Task<List<CoveragePlan>> GetAllByDetails()
        {
            return await _coveragePlanDALC.GetAllByDetails();
        }

        public async Task<List<CoveragePlan>> GetCoveragePlansByRamo(int RamoID)
        {
            return await _coveragePlanDALC.GetCoveragePlansByRamo(RamoID);
        }

        public async Task<CoveragePlan> Post(CoveragePlan item)
        {
            return await _coveragePlanDALC.Post(item);
        }

        public Task<bool> Post(BondPaymentModel item)
        {
            throw new NotImplementedException();
        }

        public Task<CoveragePlan> Put(int id, CoveragePlan item)
        {
            throw new NotImplementedException();
        }
    }
}
