using LinqKit;
using PRAXYS.Commons.Entities;
using PRAXYS.Commons.Filter;
using PRAXYS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace PRAXYS.Data.QueryFilter
{
    public static class QueryHelper
    {

        public static IQueryable<Insurance> GetInsuranceNearToExpire(AppDbContext _context, DatePickerModel filter)
        {
            IQueryable<Insurance> query = _context.Set<Insurance>();

            if (filter.FinalDate != null)
            {
                query = query.Where(x => x.ValidThrought <= filter.FinalDate);
            }

            if (filter.InitalDate != null)
            {
                query = query.Where(x => x.ValidThrought >= filter.InitalDate);
            }

            return query;
        }

        public static IQueryable<Insurance> GetFilterInsuree(AppDbContext _context, InsuranceFilter filter)
        {
            var predicate = PredicateBuilder.True<Insurance>();

            if (filter.ClientID != 0)
            {
                predicate = predicate.And(x => x.ClientID == filter.ClientID);
            }

            if (filter.CompanyID != 0)
            {
                predicate = predicate.And(x => x.CompanyID == filter.CompanyID);
            }

            if (filter.FinalDate != null)
            {
                predicate = predicate.And(x => x.ValidThrought <= filter.FinalDate);
            }

            if (filter.InitalDate != null)
            {
                predicate = predicate.And(x => x.ValidThrought >= filter.InitalDate);
            }

            return _context.Insurance.Where(predicate);
        }

        public static IQueryable<Insurance> GetFilterReport(AppDbContext _context, ReportFilterModel filter)
        {
            var predicate = PredicateBuilder.True<Insurance>();

            if (filter.Clients != null && filter.Clients.Count != 0)
            {
                predicate = predicate.And(x => filter.Clients.Contains(x.ClientID));
            }

            if (filter.Agents != null && filter.Agents.Count != 0)
            {
                predicate = predicate.And(x => filter.Agents.Contains(x.AgentID));
            }

            if (filter.Companies != null && filter.Agents.Count != 0)
            {
                predicate = predicate.And(x => filter.Companies.Contains(x.CompanyID));
            }

            return _context.Insurance
                .Where(predicate);
        }
    }
}
