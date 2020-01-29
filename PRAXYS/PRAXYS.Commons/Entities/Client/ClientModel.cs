using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PRAXYS.Commons.Entities.Client
{
    public class ClientModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string SecondLastName { get; set; }
        public DateTime? DayOfBirth { get; set; }
        public string Gender { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        public string RFC { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string PersonType { get; set; }
        public DateTime IssueDate { get; set; }
        public string CompanyName { get; set; }

        public List<ClientAddressModel> ClientAddresses { get; set; }
        public List<ClientDocumentationModel> ClientDocumentation { get; set; }
    }
}
