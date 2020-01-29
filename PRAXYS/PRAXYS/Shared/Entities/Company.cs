using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PRAXYS.Shared.Entities
{
    public class Company
    {
        public int ID { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string RFC { get; set; }
        
        public string CompanyClassification { get; set; }
        [Required]
        public string CompanyType  { get; set; }
        public DateTime? ConstitutionDate { get; set; }
        public DateTime IssueDate { get; set; }
        public string Alias { get; set; }
        [Required]
        public int Days_Payment_First_Recibe_New { get; set; }
        [Required]
        public int Days_Payment_First_Recibe_Renewal { get; set; }

        public List<Company_Address> CompanyAddress { get; set; }
        public List<Agent> AgentList { get; set; }
    }
}
