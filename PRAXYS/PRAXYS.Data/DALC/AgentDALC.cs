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
    public static class AgentDALC
    {
        
        public static async Task<bool> AgentDelete(this AppDbContext _context, int id)
        {
            try
            {

                var Agent = await _context.Agent
                    .Where(x => x.ID == id)
                    .SingleOrDefaultAsync();

                _context.Entry(Agent).State = EntityState.Deleted;
                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static async Task<Agent> AgentGet(this AppDbContext _context, int id)
        {
            try
            {
                return await _context.Agent
                    .Where(x => x.ID == id)
                    .SingleOrDefaultAsync();
            }
            catch (Exception)
            {

                return null;
            }
        }

        public static async Task<List<Agent>> AgentGetAll(this AppDbContext _context)
        {
            try
            {
                return await _context.Agent
                    .ToListAsync();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static async Task<List<Agent>> AgentGetAllByDetails(this AppDbContext _context)
        {
            try
            {
                return await _context.Agent
                    .Include(x => x.Agent_Addresses)
                    .ThenInclude(x => x.Address)
                    .ToListAsync();
            }
            catch (Exception)
            {

                return null;
            }
        }

        public static async Task<bool> AgentPost(this AppDbContext _context, Agent item)
        {
            try
            {
                _context.Agent.Add(item);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static async Task<bool> AgentPut(this AppDbContext _context, int id, Agent item)
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
