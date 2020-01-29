using System;
using System.Collections.Generic;
using System.Text;

namespace PRAXYS.Shared.Entities
{
    public class Clients
    {
        public int ID { get; set; }
        
        public string Name { get; set; }
        public string LastName { get; set; }
        public string SecondLastName { get; set; }
        public DateTime? DayOfBirth { get; set; }
        public string Gender { get; set; }
        public string RFC { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string PersonType { get; set; }
        public DateTime IssueDate { get; set; }
        public string CompanyName { get; set; }

        public List<Client_Address> ClientAddresses { get; set; }
        public List<Contact> ContactList { get; set; }
        public List<ClientDocumentation> ClientDocumentation { get; set; }
    }
}
