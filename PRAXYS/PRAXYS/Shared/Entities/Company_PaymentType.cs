using System;
using System.Collections.Generic;
using System.Text;

namespace PRAXYS.Shared.Entities
{
    public class Company_PaymentType
    {
        public int CompanyID { get; set; }
        public int PaymenTypeID { get; set; }

        public Company Company { get; set; }
        public PaymentType Payment { get; set; }
    }
}
