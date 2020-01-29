using Microsoft.EntityFrameworkCore;
using PRAXYS.Commons.Entities;
using PRAXYS.Commons.Filter;
using PRAXYS.Data.Intefaces;
using PRAXYS.Data.QueryFilter;
using PRAXYS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRAXYS.Data.DALC
{
    public static class InsuranceDALC 
    {
        
        public async static Task<Insurance> InsuranceDelete(this AppDbContext context, int id)
        {
            try
            {
                var insurance = await context.Insurance
                    .Where(x => x.ID == id)
                    .SingleOrDefaultAsync();
                
                context.Entry(insurance).State = EntityState.Deleted;
                await context.SaveChangesAsync();

                return insurance;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static async Task<Insurance> InsuranceGet(this AppDbContext context, int id)
        {
            return await context.Insurance
               .Include(x => x.Company)
               .Include(x => x.Client)
               .Include(x => x.Agent)
               .Include(x => x.InsuranceDocumentation)
               .Where(x => x.ID == id).SingleOrDefaultAsync();
        }

        public static async Task<List<Insurance>> InsuranceGetAll(this AppDbContext context)
        {
            try
            {
                return await context.Insurance
                .ToListAsync();
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public static async Task<List<Insurance>> InsuranceGetAllByClientID(this AppDbContext context, int id)
        {
            return await context.Insurance
                .Include(x => x.Company)
                .Include(x => x.Client)
                .Include(x => x.Agent)           
                .Include(x => x.SubBranch)
                .Where(x => x.ClientID == id)
                .ToListAsync();
        }

        public static async Task<List<Insurance>> InsuranceGetAllByAgentID(this AppDbContext context, int id)
        {
            return await context.Insurance
                .Include(x => x.Company)
                .Include(x => x.Client)
                .Include(x => x.Agent)
                .Include(x => x.SubBranch)
                .Where(x => x.AgentID == id)
                .ToListAsync();
        }

        public static async Task<List<Insurance>> InsuranceGetAllByCompanyID(this AppDbContext context, int id)
        {
            return await context.Insurance
                .Include(x => x.Company)
                .Include(x => x.Client)
                .Include(x => x.Agent)
                .Include(x => x.SubBranch)
                .Where(x => x.CompanyID == id)
                .ToListAsync();
        }

        public static async Task<List<Insurance>> InsuranceGetAllBySubAgentID(this AppDbContext context, int id)
        {
            return await context.Insurance
                .Include(x => x.Company)
                .Include(x => x.Client)
                .Include(x => x.Agent)
                .Include(x => x.SubBranch)
                .Where(x => x.SubAgentID == id)
                .ToListAsync();
        }

        public static async Task<List<Insurance>> InsuranceGetAllWithInsuranceNumber(this AppDbContext context, string insuranceNumber)
        {
            return await context.Insurance
                .Include(x => x.Company)
                .Include(x => x.Client)
                .Include(x => x.Agent)
                .Include(x => x.SubBranch)
                .Where(x => x.InsuranceNumber == insuranceNumber)
                .ToListAsync();
        }

        public static async Task<List<Insurance>> InsuranceGetAllWithoutEndorsement(this AppDbContext context)
        {
            try
            {
                return await context.Insurance
                    .Include(x => x.Company)
                    .Include(x => x.Client)
                    .Include(x => x.Agent)
                    .Include(x => x.SubBranch)
                    .Where(x => !x.Endorsement)
                    .ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static async Task<List<Insurance>> InsuranceGetAllByDetails(this AppDbContext context)
        {
            return await context.Insurance
                .Include(x => x.Company)
                .Include(x => x.Client)
                .Include(x => x.Agent)
                .Include(x => x.SubBranch)
                .Include(x => x.PaymentType)
                .ToListAsync();
        }

        public static async Task<List<Insurance>> InsuranceGetAllByFilter(this AppDbContext context, InsuranceFilter filter)
        {
            return await QueryHelper.GetFilterInsuree(context, filter)
                .Include(x => x.Company)
                .Include(x => x.Client)
                .Include(x => x.Agent)
                .Include(x => x.SubBranch)
                .ToListAsync();
        }

        public static Task<List<Insurance>> InsuranceGetAllNextToExpire(this AppDbContext context ,int id)
        {
            throw new NotImplementedException();
        }

        public static async Task<Insurance> InsuranceGetByDetails(this AppDbContext context, int id)
        {
            try
            {
                return await context.Insurance
                    .Include(x => x.Client)
                    .Include(x => x.Agent)
                    .Include(x => x.Company)
                    .Include(x => x.SubAgent)
                    .Include(x => x.SubBranch)
                    .Include(x => x.PaymentType)
                    .Include(x => x.InsuranceDocumentation)
                    .Where(x => x.ID == id).FirstOrDefaultAsync();
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

        public static async Task<List<Insurance>> InsuranceGetNextToExpire(this AppDbContext context, DatePickerModel datePicker)
        {
            return await QueryHelper.GetInsuranceNearToExpire(context, datePicker)
                .Include(x => x.Company)
                .ToListAsync();
        }

        public static async Task<Insurance> InsurancePost(this AppDbContext context, Insurance item)
        {
            try
            {
                context.Insurance.Add(item);
                await context.SaveChangesAsync();

                return item;
            }
            catch (Exception e)
            {
                throw e;
                //return null;
            }
        }

        public async static Task<Insurance> InsurancePut(this AppDbContext context, int id, Insurance item)
        {
            try
            {
                context.Entry(item).State = EntityState.Modified;
                await context.SaveChangesAsync();

                return item;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static async Task<List<Insurance>> GetInsurancesByReportFilter(this AppDbContext context, ReportFilterModel reportFilter)
        {
            return await QueryHelper.GetFilterReport(context, reportFilter)
                .Include(x => x.Agent)
                .Include(x => x.Client)
                .Include(x => x.Company)
                .ToListAsync();
        }

        public static async Task<List<Insurance>> InsuranceGetAllWithEndorsement(this AppDbContext context, string InsuranceNumber)
        {
            try
            {
                return await context.Insurance
                    .Include(x => x.Endorsements).ThenInclude(x => x.EndorsementType)
                    .Where(x => x.InsuranceNumber == InsuranceNumber)
                    .ToListAsync();
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
