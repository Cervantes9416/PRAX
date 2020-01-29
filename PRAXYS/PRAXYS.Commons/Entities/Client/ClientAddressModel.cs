using PRAXYS.Commons.Entities.Address;
using System;
using System.Collections.Generic;
using System.Text;

namespace PRAXYS.Commons.Entities.Client
{
    public class ClientAddressModel
    {
        public int ClientID { get; set; }
        public int AddressID { get; set; }

        public AddressModel Address { get; set; }
    }
}
