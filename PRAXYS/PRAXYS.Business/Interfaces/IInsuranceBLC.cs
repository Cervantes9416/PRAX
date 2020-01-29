using PRAXYS.Commons.Entities;
using PRAXYS.Commons.Entities.Insurance;
using PRAXYS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PRAXYS.Business.Interfaces
{
    public interface IInsuranceBLC : IGenericBLC<Insurance>
    {
        Task<List<Insurance>> GetAllByDetails();
        Task<List<Insurance>> GetAllByClientID(int id);
        Task<List<Insurance>> GetAllNextToExpire(int id);
        Task<List<InsuranceCardModel>> GetInsuranceNextToExpire(DatePickerModel datePickerModel);
        Task<List<Insurance>> GetAllByFilter(InsuranceFilter filter);
        Task<Insurance> GetByDetails(int id);
        Task<List<InsuranceEndorsementModel>> GetAllWithInsuranceNumber(string insuranceNumber);
        Task<List<InsuranceListModel>> GetAllWithoutEndorsement();
        Task<List<Insurance>> GetAllByAgentID(int id);
        Task<List<Insurance>> GetAllByCompanyID(int id);
        Task<List<Insurance>> GetAllBySubAgentID(int id);
        Task<bool> CancelInsurance(InsuranceModel item);
    }
}
