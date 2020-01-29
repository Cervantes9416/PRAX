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
    public static class SubAgentDALC
    {
        

        public static async Task<bool> SubAgentDelete(this AppDbContext _context ,int id)
        {
            try
            {
                var subAgent = await _context.SubAgent
                    .Where(x => x.ID == id)
                    .FirstOrDefaultAsync();

                _context.Entry(subAgent).State = EntityState.Deleted;
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static async Task<SubAgent> SubAgentGet(this AppDbContext _context, int id)
        {
            try
            {
                return await _context.SubAgent
                    .Where(x => x.ID == id)
                    .SingleOrDefaultAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static async Task<List<SubAgent>> SubAgentGetAll(this AppDbContext _context)
        {
            try
            {
                return await _context.SubAgent
                     .ToListAsync();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static async Task<bool> SubAgentPost(this AppDbContext _context, SubAgent item)
        {
            try
            {
                //_context.SubAgent.Add(item);
                _context.Attach(item);
                _context.Entry(item).State = EntityState.Added;
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static async Task<bool> SubAgentPut(this AppDbContext _context, int id, SubAgent item)
        {
            try
            {
                _context.Entry(item).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
