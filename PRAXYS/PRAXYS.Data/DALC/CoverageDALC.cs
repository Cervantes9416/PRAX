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
    public class CoverageDALC : ICoverageDALC
    {
        private AppDbContext _context;

        public CoverageDALC(AppDbContext context)
        {
            this._context = context;
        }

        public Task<Coverage> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Coverage> Get(int id)
        {
            return await _context.Coverage
                .Where(x => x.ID == id)
                .SingleOrDefaultAsync();
        }

        public async Task<List<Coverage>> GetAll()
        {
            return await _context.Coverage
                .ToListAsync();
        }

        public async Task<List<Coverage>> GetAllByDeatils()
        {
            return await _context.Coverage
                .Include(x => x.Ramo_Coverages).ThenInclude(x => x.Branch)
                .ToListAsync();
        }

        public async Task<List<Coverage>> GetCoverageByRamo(int RamoID)
        {
            return await _context.Ramo_Coverage
                .Where(x => x.BranchID == RamoID)
                .Select(x => x.Coverage)
                .ToListAsync();
        }

        public async Task<Coverage> Post(Coverage item)
        {
            _context.Coverage.Add(item);

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

        public async Task<Coverage> Put(int id, Coverage item)
        {
            throw new NotImplementedException();
        }
    }
}
