using PRAXYS.Commons.Filter;
using PRAXYS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PRAXYS.Business.Interfaces
{
    public interface IReportBLC : IGenericBLC<object>
    {
        Task<List<Insurance>> GetReportByFilter(ReportFilterModel reportFilter);
        void ReportValid();
    }
}
