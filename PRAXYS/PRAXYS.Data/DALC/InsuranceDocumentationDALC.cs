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
    public static class InsuranceDocumentationDALC
    {
        
        public static async Task<bool> InsuranceDocumentDelete(this AppDbContext _context ,int id)
        {
            try
            {
                var document = await _context.InsuranceDocumentation
                    .Where(x => x.ID == id)
                    .SingleOrDefaultAsync();

                _context.Entry(document).State = EntityState.Deleted;
                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static async Task<InsuranceDocumentation> InsuranceDocumentGet(this AppDbContext _context, int id)
        {
            try
            {
                var document = await _context.InsuranceDocumentation
                    .Where(x => x.ID == id)
                    .SingleOrDefaultAsync();

                return document;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static async Task<List<InsuranceDocumentation>> InsuranceDocumentGetAll(this AppDbContext _context)
        {
            try
            {
                var document = await _context.InsuranceDocumentation
                    .ToListAsync();

                return document;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static async Task<List<InsuranceDocumentation>> InsuranceDocumentGetAllByID(this AppDbContext _context, int id)
        {
            try
            {
                return await _context.InsuranceDocumentation
                    .Where(x => x.InsuranceID == id)
                    .ToListAsync();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static async Task<bool> InsuranceDocumentPost(this AppDbContext _context, InsuranceDocumentation item)
        {
            try
            {
                _context.InsuranceDocumentation.Add(item);
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
