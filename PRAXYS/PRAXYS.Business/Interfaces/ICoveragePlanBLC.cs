using PRAXYS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PRAXYS.Business.Interfaces
{
    public interface ICoveragePlanBLC : IGenericBLC<CoveragePlan>
    {
        Task<List<CoveragePlan>> GetAllByDetails();
        Task<List<CoveragePlan>> GetCoveragePlansByRamo(int RamoID);
    }
}
