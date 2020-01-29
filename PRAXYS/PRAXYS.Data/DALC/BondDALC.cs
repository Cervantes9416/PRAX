using Microsoft.EntityFrameworkCore;
using PRAXYS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRAXYS.Data.DALC
{
    public static class BondDALC
    {
        public async static Task<List<Bond>> GetAllBonds(this AppDbContext context)
        {
            try
            {
                return await context.Bond.ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async static Task<List<Bond>> GetAllBondsWithDetails(this AppDbContext context)
        {
            try
            {
                return await context.Bond
                    .Include(x => x.Company)
                    .Include(x => x.Client)
                    .Include(x => x.Agent)
                    .Include(x => x.SubAgent)
                    .Include(x => x.BondPayments).ThenInclude(x => x.CommissionPayments)
                    .ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async static Task<Bond> BondGet(this AppDbContext context, int id)
        {
            try
            {
                return await context.Bond
                    .Where(x => x.ID == id)
                    .FirstOrDefaultAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async static Task<Bond> BondGetWithDetails(this AppDbContext context, int id)
        {
            try
            {
                return await context.Bond
                    .Include(x => x.Company)
                    .Include(x => x.Client)
                    .Include(x => x.Agent)
                    .Include(x => x.SubAgent)
                    .Include(x => x.BondPayments).ThenInclude(x => x.CommissionPayments)
                    .Where(x => x.ID == id)
                    .FirstOrDefaultAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async static Task<Bond> BondPost(this AppDbContext context, Bond item)
        {
            try
            {
                context.Bond.Add(item);
                await context.SaveChangesAsync();
                return item;
            }
            catch (Exception e)
            {

                throw;
            }
        }
    }
}
