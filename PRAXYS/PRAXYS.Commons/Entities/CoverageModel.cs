using System;
using System.Collections.Generic;
using System.Text;

namespace PRAXYS.Commons.Entities
{
    public class CoverageModel
    {
        public int ID { get; set; }
        public string Descripcion { get; set; }
        public decimal Deductible { get; set; }
        public int CovergaPlanID { get; set; }

        public List<RamoCoverageModel> Ramo_Coverages { get; set; }
    }
}
