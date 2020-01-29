using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PRAXYS.Shared.Entities
{
    public class Agent
    {
        public int ID { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }
        [MaxLength(50)]
        public string SecondLastName { get; set; }
        [MaxLength(50)]
        public string IdentificationCardNumber { get; set; }
        public DateTime? ExpirationDate { get; set; }
        [MaxLength(50)]
        public string Code { get; set; }
        [MaxLength(50)]
        public string PersonalEmail { get; set; }
        [MaxLength(50)]
        public string PersonType { get; set; }
        [MaxLength(50)]
        public string PhoneNumber { get; set; }
        [MaxLength(50)]
        public DateTime IssueDate { get; set; }
        [MaxLength(50)]
        public string CompanyName { get; set; }
        public bool Status { get; set; }

        

        public List<Agent_Address> Agent_Addresses { get; set; }
    }
}
