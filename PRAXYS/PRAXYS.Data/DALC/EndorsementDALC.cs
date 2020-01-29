using Microsoft.EntityFrameworkCore;
using PRAXYS.Commons.Entities.Endorsement;
using PRAXYS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRAXYS.Data.DALC
{
    public static class EndorsementDALC
    {
        public static async Task<bool> EndorsementCreate(this AppDbContext context, Endorsement item)
        {
            try
            {
                context.Endorsement.Add(item);
                await context.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static async Task<bool> EndorsementDelete(this AppDbContext context, int id)
        {
            try
            {
                var endorsement= await context.Endorsement
                    .Where(x => x.ID == id)
                    .SingleOrDefaultAsync();

                context.Entry(endorsement).State = EntityState.Deleted;
                await context.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public static async Task<Endorsement> EndorsementGetWithInsuranceID(this AppDbContext context, int id)
        {
            try
            {
                var endorsement = await context.Endorsement
                    .Where(x => x.InsuranceID == id)
                    .FirstOrDefaultAsync();

                return endorsement;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public static async Task<List<Endorsement>> EndorsementWithInsuranceNumber(this AppDbContext context, string insuranceNumber)
        {
            try
            {
                return await context.Endorsement
                    .Where(x => x.Insurance.InsuranceNumber == insuranceNumber)
                    .ToListAsync();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
