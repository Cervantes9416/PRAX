using PRAXYS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PRAXYS.Data.DALC
{
    public static class ComissionPaymentDALC
    {
        public static async Task<bool> ComissionPaymentCreate(this AppDbContext context, CommissionPayment item)
        {
            try
            {
                context.Add(item);
                await context.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
