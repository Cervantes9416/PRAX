using PRAXYS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PRAXYS.Data.Report
{
    public class ReportModel
    {
        public Agent Agents { get; set;}
        public int AgentID { get; set; }
        public List<Company> Companies { get; set; }
        public List<int> CompaniesID { get; set; }
        public List<Insurance> Insurances { get; set; }
    }
}
