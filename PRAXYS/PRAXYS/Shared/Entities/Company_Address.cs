using System;
using System.Collections.Generic;
using System.Text;

namespace PRAXYS.Shared.Entities
{
    public class Company_Address
    {
        public int CompanyID { get; set; }
        public int AddressID { get; set; }

        public Company Company { get; set; }
        public Address Address { get; set; }
    }
}
