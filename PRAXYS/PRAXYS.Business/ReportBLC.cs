using Microsoft.AspNetCore.Hosting;
using PRAXYS.Business.Helpers;
using PRAXYS.Business.Interfaces;
using PRAXYS.Commons.Filter;
using PRAXYS.Data;
using PRAXYS.Data.Intefaces;
using PRAXYS.Data.Report;
using PRAXYS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRAXYS.Data.DALC;
using PRAXYS.Commons.Entities.BondPayment;

namespace PRAXYS.Business
{
    public class ReportBLC : IReportBLC
    {
        private IHostingEnvironment _env;
        private AppDbContext _context;

        //private IInsuranceDALC _insuranceDALC;

        public ReportBLC(IHostingEnvironment env,AppDbContext context)
        {
            this._env = env;
            this._context = context;
        }

        public Task<object> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<object> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<object>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<object> Post(object item)
        {
            throw new NotImplementedException();
        }

        public Task<object> Put(int id, object item)
        {
            throw new NotImplementedException();
        }

        public void ReportValid()
        {
            //_env.GenerateReportValidDocument();
        }

        public async Task<List<Insurance>> GetReportByFilter(ReportFilterModel reportFilter)
        {
            var insurances = await _context.GetInsurancesByReportFilter(reportFilter);

            var Agents = insurances.Select(x => x.AgentID).Distinct().ToList();
            var AgentsEntity = insurances.Select(x => x.Agent).Distinct().ToList();

            List<ReportModel> reports = new List<ReportModel>();
            ReportModel reportModel = new ReportModel();

            foreach (var item in AgentsEntity)
            {
                reportModel.Agents = item;
                
                reportModel.Companies = insurances
                    .Where(x => x.AgentID == item.ID)
                    .Select(x => x.Company)
                    .Distinct()
                    .ToList();

                reportModel.Insurances = insurances
                    .Where(x => x.AgentID == item.ID && reportModel.Companies .Contains(x.Company))
                    .ToList();

                reports.Add(reportModel);
                reportModel = new ReportModel();
            }

            _env.GenerateReportValidDocument(reports);
            ExcelHelper.GenerateReport();
            return insurances;
        }

        public Task<bool> Post(BondPaymentModel item)
        {
            throw new NotImplementedException();
        }
    }
}
