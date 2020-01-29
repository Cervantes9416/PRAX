using PRAXYS.Commons.Entities.Company;
using PRAXYS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PRAXYS.Business.Interfaces
{
    public interface ICompanyBLC
    {
        Task<bool> Delete(int id);
        Task<List<CompanyModel>> GetAll();
        Task<List<CompanyModel>> GetAllByDetails();
        Task<CompanyModel> GetByDetail(int id);
        Task<bool> Post(CompanyModel item);
        Task<bool> Put(int id, CompanyModel item);
    }
}
