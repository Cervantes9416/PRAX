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
    public static class PaymentTypeDALC
    {
        
        public static async Task<List<PaymentType>> PaymentTypeGetAll(this AppDbContext _context)
        {
            try
            {
                return await _context.PaymentType
                    .ToListAsync();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static async Task<PaymentType> PaymentTypeGet(this AppDbContext _context, int id)
        {
            try
            {
                return await _context.PaymentType
                    .Where(x => x.ID == id)
                    .FirstOrDefaultAsync();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static async Task<PaymentType> PaymentTypePost(this AppDbContext _context, PaymentType item)
        {
            try
            {
                _context.PaymentType
                    .Add(item);

                await _context.SaveChangesAsync();

                return item;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public async static Task<bool> PaymentTypePut(this AppDbContext _context, int id, PaymentType item)
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

        public async static Task<bool> PaymentTypeDelete(this AppDbContext _context, int id)
        {
            try
            {
                var payment = await _context.PaymentType
                    .Where(x => x.ID == id)
                    .FirstOrDefaultAsync();

                _context.Entry(payment).State = EntityState.Deleted;
                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
