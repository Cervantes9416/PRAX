using PRAXYS.Commons.Entities.Insurance;
using PRAXYS.Commons.Entities.RegisterPayment;
using System;
using System.Collections.Generic;
using System.Text;

namespace PRAXYS.Commons.Entities.PaymentInformation
{
    public class PaymentInformationModel
    {
        public int ID { get; set; }
        public decimal Premium { get; set; }
        public int InsuranceID { get; set; }
        public DateTime PaymentExpirationDate { get; set; }
        public string PaymentNumber { get; set; }
        public bool Payed { get; set; }
        public bool Canceled { get; set; }
        public bool Disabled { get; set; }
        public DateTime IssueDate { get; set; }
        public string InsuranceNumber { get; set; }

        public InsuranceModel Insurance { get; set; }
        public InsurancePaymentModel RegisterPayment { get; set; }
    }
}
