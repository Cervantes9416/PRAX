using PRAXYS.Commons.Entities;
using PRAXYS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PRAXYS.Data.Intefaces
{
    public interface IInsuranceDALC : IGenericDALC<Insurance>
    {
        Task<List<Insurance>> GetAllByDetails();
        Task<List<Insurance>> GetAllByClientID(int id);
        Task<List<Insurance>> GetAllNextToExpire(int id);
        Task<List<Insurance>> GetInsuranceNextToExpire(DatePickerModel datePickerModel);
        Task<List<Insurance>> GetAllByFilter(InsuranceFilter filter);
        Task<Insurance> GetByDetails(int id);
        Task<List<Insurance>> GetInsurancesByReportFilter(Commons.Filter.ReportFilterModel reportFilter);
    }
}
