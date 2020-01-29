using PRAXYS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PRAXYS.Data.Intefaces
{
    public interface ICoveragePlanDALC : IGenericDALC<CoveragePlan>
    {
        Task<List<CoveragePlan>> GetAllByDetails();
        Task<List<CoveragePlan>> GetCoveragePlansByRamo(int RamoID);
    }
}
