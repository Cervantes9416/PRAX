using PRAXYS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PRAXYS.Data.Intefaces
{
    public interface IClientDALC : IGenericDALC<Clients>
    {
        Task<Clients> GetByDetails(int id);
    }
}
