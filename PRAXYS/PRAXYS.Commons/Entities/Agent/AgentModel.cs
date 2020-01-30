using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PRAXYS.Commons.Entities.Agent
{
    public class AgentModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string SecondLastName { get; set; }
        public string IdentificationCardNumber { get; set; }
        public DateTime? ExpirationDate { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        public string Code { get; set; }
        public string PersonalEmail { get; set; }
        public string PersonType { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime IssueDate { get; set; }
        public string CompanyName { get; set; }
        public bool Status { get; set; }

        public List<AgentAddressModel> Agent_Addresses { get; set; }

        public string GetName()
        {
            if (this.PersonType == "Fisica")
            {
                return $"{this.Name} {this.LastName} {this.SecondLastName}";
            }

            return this.CompanyName;
        }
    }
}
