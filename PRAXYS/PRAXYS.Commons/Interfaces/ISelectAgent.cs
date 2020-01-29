using PRAXYS.Commons.Entities.Agent;
using System;
using System.Collections.Generic;
using System.Text;

namespace PRAXYS.Commons.Interfaces
{
    public interface ISelectAgent
    {
        int AgentID { get; set; }
        AgentModel Agent { get; set; }
    }
}
