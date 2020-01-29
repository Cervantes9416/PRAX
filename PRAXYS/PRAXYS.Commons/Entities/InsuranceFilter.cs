using System;
using System.Collections.Generic;
using System.Text;

namespace PRAXYS.Commons.Entities
{
    public class InsuranceFilter 
    {
        public DateTime? InitalDate { get; set; }
        public DateTime? FinalDate { get; set; }
        public int ClientID { get; set; }
        public int CompanyID { get; set; }
    }
}
