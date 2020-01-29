using PRAXYS.Commons.Entities.Agent;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PRAXYS.Commons.Entities.Company
{
    public class CompanyModel
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        public string CompanyName { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        public string RFC { get; set; }
        public string CompanyClassification { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        public string CompanyType { get; set; }
        public DateTime? ConstitutionDate { get; set; }
        public DateTime IssueDate { get; set; }
        public string Alias { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        public int Days_Payment_First_Recibe_New { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        public int Days_Payment_First_Recibe_Renewal { get; set; }

        public List<CompanyAddressModel> CompanyAddress { get; set; }
        public List<AgentModel> AgentList { get; set; }
    }
}
