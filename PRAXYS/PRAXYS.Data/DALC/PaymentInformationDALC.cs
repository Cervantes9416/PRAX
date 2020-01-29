using Microsoft.EntityFrameworkCore;
using PRAXYS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRAXYS.Data.DALC
{
    public static class PaymentInformationDALC
    {
        public async static Task<List<PaymentInformation>> GetAllPayments(this AppDbContext context)
        {
            return await context.PaymentInformation
                .ToListAsync();
        }

        public async static Task<List<PaymentInformation>> GetAllPaymentsWithInsuranceID(this AppDbContext context)
        {
            return await context.PaymentInformation
                .ToListAsync();
        }

        public async static Task<List<PaymentInformation>> PaymentInformationGetAllWithInsuranceNumber(this AppDbContext context, string insuranceNumber)
        {
            return await context.PaymentInformation
                .Include(x => x.Insurance)
                .Where(x => x.Insurance.InsuranceNumber == insuranceNumber && !x.Canceled)
                .ToListAsync();
        }


        public async static Task<List<PaymentInformation>> GetPaymentWithDetails(this AppDbContext context, int insuranceID)
        {
            try
            {
                var payments = await context.PaymentInformation
                .Include(x => x.Insurance)
                .Where(x => x.InsuranceID == insuranceID)
                .ToListAsync();

                return payments;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async static Task<bool> PaymentInformationUpdate(this AppDbContext context, PaymentInformation item)
        {
            try
            {
                context.Entry(item).State = EntityState.Modified;
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
