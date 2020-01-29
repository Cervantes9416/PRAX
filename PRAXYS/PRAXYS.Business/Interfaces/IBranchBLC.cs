using PRAXYS.Commons.Entities.Branch;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PRAXYS.Business.Interfaces
{
    public interface IBranchBLC
    {
        Task<bool> DeleteBranch(int id);
        Task<bool> DeleteSubBranch(int id);
        Task<List<BranchModel>> GetAllBranch();
        Task<List<SubBranchModel>> GetAllSubBranch();
        Task<List<SubBranchModel>> GetAllSubBranchWithBranchID(int BranchID);
        Task<SubBranchModel> GetSubBranch(int id);
        Task<bool> PostBranch(BranchModel model);
        Task<bool> PostSubBranch(SubBranchModel model);
        Task<bool> PutBranch(BranchModel model);
        Task<bool> PutSubBranch(SubBranchModel model);
    }
}
