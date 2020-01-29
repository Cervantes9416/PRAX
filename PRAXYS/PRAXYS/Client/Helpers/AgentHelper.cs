using PRAXYS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRAXYS.Client.Helpers
{
    public static class AgentHelper
    {
        public static Agent CreateNewAgent()
        {
            return new Agent()
            {
                PersonType = "Fisica",
                Status = true,
                IssueDate = DateTime.Now
            };
        }

        public static Agent CreateNewAgentWithCompanyID(int CompanyID)
        {
            return new Agent()
            {
                PersonType = "Fisica",
                Status = true,
                IssueDate = DateTime.Now,
            };
        }
    }
}
