using PRAXYS.Commons.Entities.CoveragePlan;
using System;
using System.Collections.Generic;
using System.Text;

namespace PRAXYS.Commons.Interfaces
{
    public interface ICoveragePlanContainer
    {
        int CoveragePlanID { get; set; }
        CoveragePlanModel CoveragePlan { get; set; }
    }
}
