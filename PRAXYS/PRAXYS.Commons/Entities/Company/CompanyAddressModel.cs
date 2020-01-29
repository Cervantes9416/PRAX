using PRAXYS.Commons.Entities.Address;
using System;
using System.Collections.Generic;
using System.Text;

namespace PRAXYS.Commons.Entities.Company
{
    public class CompanyAddressModel
    {
        public int CompanyID { get; set; }
        public int AddressID { get; set; }

        public AddressModel Address { get; set; }
    }
}
