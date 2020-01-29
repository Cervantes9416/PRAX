using PRAXYS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PRAXYS.Business.Interfaces
{
    public interface ICoverageBLC : IGenericBLC<Coverage>
    {
        Task<List<Coverage>> GetAllByDeatils();
        Task<List<Coverage>> GetCoverageByRamo(int RamoID);
    }
}
