using System;
using System.Collections.Generic;
using System.Text;

namespace PRAXYS.Shared.Entities
{
    public class Coverage
    {
        public int ID { get; set; }
        public string Descripcion { get; set; }
        public decimal Deductible { get; set; }
        public int CovergaPlanID { get; set; }

        public List<CoveragePlan_Coverage> CoveragePlan_Coverages { get; set; }
        public List<Ramo_Coverage> Ramo_Coverages { get; set; }
    }
}
