using PRAXYS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PRAXYS.Data.Intefaces
{
    public interface ICompanyDALC : IGenericDALC<Company>
    {
        Task<List<Company>> GetAllByDetails();
        Task<Company> GetByDetails(int id);
    }
}
