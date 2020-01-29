using PRAXYS.Commons.Entities.Address;
using System;
using System.Collections.Generic;
using System.Text;

namespace PRAXYS.Commons.Entities.Agent
{
    public class AgentAddressModel
    {
        public int AgentID { get; set; }
        public int AddressID { get; set; }
        
        public AddressModel Address { get; set; }
    }
}
