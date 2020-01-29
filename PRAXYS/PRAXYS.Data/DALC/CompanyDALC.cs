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
    public static class CompanyDALC
    {

        public static async Task<bool> CompanyDelete(this AppDbContext _context ,int id)
        {
            try
            {
                var company = await _context.Company
                    .Where(x => x.ID == id)
                    .SingleOrDefaultAsync();

                _context.Entry(company).State = EntityState.Deleted;
                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static async Task<Company> CompanyGet(this AppDbContext _context, int id)
        {
            try
            {
                return await _context.Company
                    .Where(x => x.ID == id)
                    .FirstOrDefaultAsync();
            }
            catch (Exception)
            {

                return null;
            }
        }

        public static async Task<List<Company>> CompanyGetAll(this AppDbContext _context)
        {
            try
            {
                return await _context.Company
                .ToListAsync();
            }
            catch (Exception)
            {

                return null;
            }
        }

        public static async Task<List<Company>> CompanyGetAllByDetails(this AppDbContext _context)
        {
            try
            {
                return await _context.Company
                .Include(x => x.CompanyAddress)
                .ThenInclude(x => x.Address)
                .Include(x => x.AgentList)
                .ToListAsync();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static async Task<Company> CompanyGetByDetails(this AppDbContext _context, int id)
        {
            try
            {
                return await _context.Company
                  .Include(x => x.CompanyAddress)
                  .ThenInclude(x => x.Address)
                  .Include(x => x.AgentList)
                  .Where(x => x.ID == id)
                  .SingleOrDefaultAsync();
            }
            catch (Exception)
            {

                return null;
            }
        }

        public static async Task<bool> CompanyPost(this AppDbContext _context, Company item)
        {
            try
            {
                _context.Add(item);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static async Task<bool> CompanyPut(this AppDbContext _context, int id, Company item)
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
