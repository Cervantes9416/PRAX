using PRAXYS.Commons.Entities.Insurance;
using PRAXYS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PRAXYS.Business.Interfaces
{
    public interface IInsuranceDocumentationBLC
    {
        Task<bool> Delete(int id);
        Task<string> DowloadDocument(int id);
        Task<InsuranceDocumentationModel> DowloadDocumentFile(int id);
        Task<InsuranceDocumentationModel> Get(int id);
        Task<List<InsuranceDocumentationModel>> GetAll();
        Task<List<InsuranceDocumentationModel>> GetAllByID(int id);
        Task<bool> PostInsuranceDocument(InsuranceDocumentationModel item);
        Task<InsuranceDocumentationModel> ViewDocumentFile(int id);
    }
}
