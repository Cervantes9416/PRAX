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
    public static class ClientDocumentationDALC
    {
        
        public static async Task<bool> ClientDocumentationDelete(this AppDbContext _context, int id)
        {
            try
            {
                var document = await _context.ClientDocumentation
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

        public static async Task<ClientDocumentation> ClientDocumentationGet(this AppDbContext _context ,int id)
        {
            try
            {
                return await _context.ClientDocumentation
                    .Where(x => x.ID == id)
                    .SingleOrDefaultAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static async Task<List<ClientDocumentation>> ClientDocumentationGetAll(this AppDbContext _context)
        {
            try
            {
                return await _context.ClientDocumentation
                    .ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static async Task<List<ClientDocumentation>> ClientDocumentationGetAllByID(this AppDbContext _context, int id)
        {
            try
            {
                return await _context.ClientDocumentation
                    .Where(x => x.ClientID == id)
                    .ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static async Task<ClientDocumentation> ClientDocumentationPost(this AppDbContext _context, ClientDocumentation item)
        {
            try
            {
                _context.ClientDocumentation.Add(item);
                await _context.SaveChangesAsync();
                return item;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static async Task<bool> ClientDocumentationPut(this AppDbContext _context, int id, ClientDocumentation item)
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
