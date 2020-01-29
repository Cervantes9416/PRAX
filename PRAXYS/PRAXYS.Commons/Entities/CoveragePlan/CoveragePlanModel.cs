using PRAXYS.Commons.Entities.Ramo;
using System;
using System.Collections.Generic;
using System.Text;

namespace PRAXYS.Commons.Entities.CoveragePlan
{
    public class CoveragePlanModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int RamoID { get; set; }

        public RamoModel Ramo {get;set;}
        public List<CoveragePlanCoveragesModel> CoveragePlan_Coverages { get; set; }

    }
}
