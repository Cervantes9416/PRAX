using System;
using System.Collections.Generic;
using System.Text;

namespace PRAXYS.Shared.Entities
{
    public class CoveragePlan_Coverage
    {
        public int CoveragePlanID { get; set; }
        public int CoverageID { get; set; }

        public CoveragePlan CoveragePlan { get; set; }
        public Coverage Coverage { get; set; }
    }
}
