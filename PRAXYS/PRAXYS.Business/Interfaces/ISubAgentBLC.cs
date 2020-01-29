using PRAXYS.Commons.Entities.SubAgent;
using PRAXYS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PRAXYS.Business.Interfaces
{
    public interface ISubAgentBLC
    {
        Task<bool> Delete(int id);
        Task<SubAgentModel> Get(int id);
        Task<List<SubAgentModel>> GetAll();
        Task<bool> Post(SubAgentModel item);
        Task<bool> Put(int id, SubAgentModel item);
    }
}
