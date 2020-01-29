using System;
using System.Collections.Generic;
using System.Text;

namespace PRAXYS.Commons.Entities.SubAgent
{
    public class SubAgentModel
    {
        public int ID { get; set; }
        public string CompanyName { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string SecondLastName { get; set; }
        public string PersonType { get; set; }
        public string PersonalEmail { get; set; }
        public string RFC { get; set; }
        public string IdentificationNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string Bank { get; set; }
        public bool Status { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
    }
}
