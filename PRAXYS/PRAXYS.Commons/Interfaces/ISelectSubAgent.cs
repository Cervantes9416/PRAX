using PRAXYS.Commons.Entities.SubAgent;
using System;
using System.Collections.Generic;
using System.Text;

namespace PRAXYS.Commons.Interfaces
{
    public interface ISelectSubAgent
    {
        int SubAgentID { get; set; }
        SubAgentModel SubAgent {get;set;}
    }
}
