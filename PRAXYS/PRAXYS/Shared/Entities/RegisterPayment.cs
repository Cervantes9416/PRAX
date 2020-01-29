using System;
using System.Collections.Generic;
using System.Text;

namespace PRAXYS.Shared.Entities
{
    public class RegisterPayment
    {
        public int ID { get; set; }
        public string Bank { get; set; }
        public decimal PaymentAmount { get; set; }
        public DateTime? DateRegistered { get; set; }
        public string DocumentType{ get; set; }
        public DateTime DatePayment { get; set; }
        public int PaymentInformationID { get; set; }
        public int InsuranceID { get; set; }
        public DateTime? IssueDate { get; set; }

        public Insurance Insurance { get; set; }
        public PaymentInformation PaymentInformation { get; set; }
    }
}
