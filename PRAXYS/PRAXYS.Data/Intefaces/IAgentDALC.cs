using PRAXYS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PRAXYS.Data.Intefaces
{
    public interface IAgentDALC : IGenericDALC<Agent>
    {
        Task<List<Agent>> GetAllByDetails();
    }
}
