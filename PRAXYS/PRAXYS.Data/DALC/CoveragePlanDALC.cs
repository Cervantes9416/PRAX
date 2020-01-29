using Microsoft.EntityFrameworkCore;
using PRAXYS.Data.Intefaces;
using PRAXYS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRAXYS.Data.DALC
{
    public class CoveragePlanDALC : ICoveragePlanDALC
    {
        private readonly AppDbContext _context;

        public CoveragePlanDALC(AppDbContext context)
        {
            this._context = context;
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
            return await _context.CoveragePlan
                .ToListAsync();
        }

        public async Task<List<CoveragePlan>> GetAllByDetails()
        {
            return await _context.CoveragePlan
                .Include(x => x.CoveragePlan_Coverages)
                .ThenInclude(x => x.Coverage)
                .Include(x => x.Ramo)
                .ToListAsync();
        }

        public async Task<List<CoveragePlan>> GetCoveragePlansByRamo(int RamoID)
        {
            return await _context.CoveragePlan
                .Include(x => x.CoveragePlan_Coverages)
                .ThenInclude(x => x.Coverage)
                .Include(x => x.Ramo)
                .Where(x => x.RamoID == RamoID)
                .ToListAsync();
        }

        public async Task<CoveragePlan> Post(CoveragePlan item)
        {
            _context.CoveragePlan.Add(item);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                return null;
            }

            return item;
        }

        public Task<CoveragePlan> Put(int id, CoveragePlan item)
        {
            throw new NotImplementedException();
        }
    }
}
