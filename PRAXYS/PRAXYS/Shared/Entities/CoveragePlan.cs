using System;
using System.Collections.Generic;
using System.Text;

namespace PRAXYS.Shared.Entities
{
    public class CoveragePlan
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int RamoID { get; set; }

        public Branch Ramo { get; set; }
        public List<CoveragePlan_Coverage> CoveragePlan_Coverages { get; set; }
    }
}
