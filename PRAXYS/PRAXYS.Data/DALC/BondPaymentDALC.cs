using Microsoft.EntityFrameworkCore;
using PRAXYS.Shared.Entities; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRAXYS.Data.DALC
{
    public static class BondPaymentDALC
    {
        public static async Task<List<BondPayment>> BondPaymentGetAll(this AppDbContext context)
        {
            try
            {
                return await context.BondPayments
                    .ToListAsync();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static async Task<BondPayment> BondPaymentGet(this AppDbContext context, int id)
        {
            try
            {
                return await context.BondPayments
                    .Where(x => x.ID == id)
                    .FirstOrDefaultAsync();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static async Task<bool> BondPaymentCreate(this AppDbContext context, BondPayment bondPayment)
        {
            try
            {
                context.BondPayments.Add(bondPayment);
                await context.SaveChangesAsync();

                return true;
            }
            catch (Exception e)
            {

                return false;
            }
        }

        public static async Task<bool> BondPaymentUpdate(this AppDbContext context, BondPayment bondPayment)
        {
            try
            {
                context.Entry(bondPayment).State = EntityState.Modified;
                await context.SaveChangesAsync();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
