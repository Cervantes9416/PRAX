using System;
using System.Collections.Generic;
using System.Text;

namespace PRAXYS.Commons.Filter
{
    public class ReportFilterModel
    {
        public string SelectedReport { get; set; }
        public List<int> Agents { get; set; }
        public List<int> Companies { get; set; }
        public List<int> Clients { get; set; }
        public List<int> SubAgents { get; set; }
    }
}
