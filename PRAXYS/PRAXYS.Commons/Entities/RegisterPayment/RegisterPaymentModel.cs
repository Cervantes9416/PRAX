using PRAXYS.Commons.Entities.Insurance;
using PRAXYS.Commons.Entities.PaymentInformation;
using System;
using System.Collections.Generic;
using System.Text;

namespace PRAXYS.Commons.Entities.RegisterPayment
{
    public class RegisterPaymentModel
    {
        public int ID { get; set; }
        public string Bank { get; set; }
        public decimal PaymentAmount { get; set; }
        public DateTime? DateRegistered { get; set; }
        public string DocumentType { get; set; }
        public DateTime DatePayment { get; set; }
        public int PaymentInformationID { get; set; }
        public int InsuranceID { get; set; }
        public DateTime? IssueDate { get; set; }

        public InsuranceModel Insurance { get; set; }
        public PaymentInformationModel PaymentInformation { get; set; }
    }
}
