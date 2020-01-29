using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PRAXYS.Shared.Entities
{
    public class SubAgent
    {
        public int ID { get; set; }
        [MaxLength(50)]
        public string CompanyName { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }
        [MaxLength(50)]
        public string SecondLastName { get; set; }
        [MaxLength(15)]
        public string PersonType { get; set; }
        [MaxLength(30)]
        public string PersonalEmail { get; set; }
        [Required]
        public string RFC { get; set; }
        [MaxLength(30)]
        public string IdentificationNumber { get; set; }
        [MaxLength(20)]
        public string PhoneNumber { get; set; }
        [MaxLength(20)]
        public string Bank { get; set; }
        public bool Status { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
    }
}
