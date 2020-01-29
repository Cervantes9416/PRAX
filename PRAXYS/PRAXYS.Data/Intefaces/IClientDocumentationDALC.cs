using PRAXYS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PRAXYS.Data.Intefaces
{
    public interface IClientDocumentationDALC : IGenericDALC<ClientDocumentation>
    {
        Task<List<ClientDocumentation>> GetAllByID(int id);
    }
}
