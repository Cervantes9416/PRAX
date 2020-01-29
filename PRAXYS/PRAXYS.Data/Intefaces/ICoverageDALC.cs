using PRAXYS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PRAXYS.Data.Intefaces
{
    public interface ICoverageDALC : IGenericDALC<Coverage>
    {
        Task<List<Coverage>> GetAllByDeatils();
        Task<List<Coverage>> GetCoverageByRamo(int RamoID);
    }
}
