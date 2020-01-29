using System;
using System.Collections.Generic;
using System.Text;

namespace PRAXYS.Shared.Entities
{
    public class Agent_Address
    {
        public int AgentID { get; set; }
        public int AddressID { get; set; }

        public Agent Agent { get; set; }
        public Address Address { get; set; }
    }
}
