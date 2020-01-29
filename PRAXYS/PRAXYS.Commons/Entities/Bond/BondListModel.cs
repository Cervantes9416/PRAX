using System;
using System.Collections.Generic;
using System.Text;

namespace PRAXYS.Commons.Entities.Bond
{
    public class BondListModel
    {
        public int ID { get; set; }
        public string BondNumber { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int CompanyID { get; set; }
        public decimal PremiumTotal { get; set; }
        public bool Payed { get; set; }

        public string Company { get; set; }
        public string Client { get; set; }
        public string Agent { get; set; }
        
    }
}
