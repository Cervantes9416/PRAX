using Microsoft.AspNetCore.Mvc;
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
    public static class ClientsDALC
    {
       
        public static async Task<Clients> ClientsDelete(this AppDbContext _context, int id)
        {
            try
            {
                var client = await _context.Clients
                    .Where(x => x.ID == id)
                    .SingleOrDefaultAsync();

                _context.Entry(client).State = EntityState.Deleted;
                await _context.SaveChangesAsync();

                return client;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static async Task<Clients> ClientsGet(this AppDbContext _context, int id)
        {
            return await _context.Clients
                .Where(x => x.ID == id)
                .SingleOrDefaultAsync();
        }

        public static async Task<List<Clients>> ClientsGetAll(this AppDbContext _context)
        {
            return await _context.Clients.ToListAsync();
        }

        public static async Task<Clients> ClientsGetByDetails(this AppDbContext _context, int id)
        {
            return await _context.Clients
                .Include(x => x.ClientAddresses)
                .ThenInclude(x => x.Address)
                .Include(x => x.ClientDocumentation)
                .Where(x => x.ID == id)
                .SingleOrDefaultAsync();
        }

        public static async Task<Clients> ClientPost(this AppDbContext _context, Clients item)
        {
            _context.Clients.Add(item);

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

        public async static Task<bool> ClientPut(this AppDbContext _context, int id, Clients item)
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
