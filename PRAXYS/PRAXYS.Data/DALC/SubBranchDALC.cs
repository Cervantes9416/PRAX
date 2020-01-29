using Microsoft.EntityFrameworkCore;
using PRAXYS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRAXYS.Data.DALC
{
    public static class SubBranchDALC
    {
        public static async Task<List<SubBranch>> SubBranchGetAll(this AppDbContext _context)
        {
            try
            {
                return await _context.SubBranch
                    .Include(x => x.Ramo)
                    .ToListAsync();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static async Task<List<SubBranch>> SubBranchGetAllWithBranchID(this AppDbContext _context,int BranchID)
        {
            try
            {
                return await _context.SubBranch
                    .Where(x => x.RamoID == BranchID)
                    .ToListAsync();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static async Task<SubBranch> SubBranchGet(this AppDbContext _context, int id)
        {
            try
            {
                return await _context.SubBranch
                    .Where(x => x.ID == id)
                    .FirstOrDefaultAsync();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static async Task<bool> SubBranchPost(this AppDbContext _context, SubBranch item)
        {
            try
            {
                _context.SubBranch.Add(item);
                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static async Task<bool> SubBranchPut(this AppDbContext _context, SubBranch item)
        {
            try
            {
                _context.Entry(item).State = EntityState.Modified;
                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static async Task<bool> SubBranchDelete(this AppDbContext _context, int id)
        {
            try
            {
                var result = await _context.SubAgent
                    .Where(x => x.ID == id)
                    .FirstOrDefaultAsync();
                _context.Entry(result).State = EntityState.Deleted;

                _context.SaveChangesAsync();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }//CLASS
}
