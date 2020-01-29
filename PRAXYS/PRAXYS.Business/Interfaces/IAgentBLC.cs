using PRAXYS.Commons.Entities.Agent;
using PRAXYS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PRAXYS.Business.Interfaces
{
    public interface IAgentBLC
    {
        Task<bool> Delete(int id);
        Task<AgentModel> Get(int id);
        Task<List<AgentModel>> GetAll();
        Task<List<AgentModel>> GetAllByDetails();
        Task<bool> Post(AgentModel item);
        Task<bool> Put(int id, AgentModel item);
    }
}
