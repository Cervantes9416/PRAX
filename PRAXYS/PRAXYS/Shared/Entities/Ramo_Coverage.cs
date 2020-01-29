using System;
using System.Collections.Generic;
using System.Text;

namespace PRAXYS.Shared.Entities
{
    public class Ramo_Coverage
    {
        public int CoverageID { get; set; }
        public int BranchID { get; set; }

        public Coverage Coverage { get; set; }
        public Branch Branch { get; set; }
    }
}
