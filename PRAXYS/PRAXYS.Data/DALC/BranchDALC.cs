using Microsoft.EntityFrameworkCore;
using PRAXYS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRAXYS.Data.DALC
{
    public static class BranchDALC
    {
        public static async Task<List<Branch>> BranchGetAll(this AppDbContext _context)
        {
            try
            {
                return await _context.Branch.ToListAsync();
            }
            catch (Exception)
            {

                return null;
            }
        }

        public static async Task<bool> BranchCreate(this AppDbContext _context, Branch branch)
        {
            try
            {
                _context.Add(branch);
                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public static async Task<bool> BranchPut(this AppDbContext _context, Branch branch)
        {
            try
            {
                _context.Entry(branch).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public static async Task<bool> BranchDelete(this AppDbContext _context, int id)
        {
            try
            {
                var branch = _context.Branch.Where(x => x.ID == id);

                _context.Entry(branch).State = EntityState.Deleted;
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
