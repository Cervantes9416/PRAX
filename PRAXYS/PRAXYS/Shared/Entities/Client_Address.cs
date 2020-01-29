using System;
using System.Collections.Generic;
using System.Text;

namespace PRAXYS.Shared.Entities
{
    public class Client_Address
    {
        public int ClientID { get; set; }
        public int AddressID { get; set; }

        public Clients Client { get; set; }
        public Address Address { get; set; }
    }
}
