using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PRAXYS.Shared.Entities
{
    public class PaymentInformation
    {
        public int ID { get; set; }
        [Required]
        public decimal Premium { get; set; }
        [Required]
        public int InsuranceID { get; set; }
        [Required]
        public DateTime PaymentExpirationDate { get; set; }
        [Required]
        public string PaymentNumber { get; set; }
        public bool Payed { get; set; }
        public bool Canceled { get; set; }
        public bool Disabled { get; set; }
        [Required]
        public DateTime IssueDate { get; set; }

        public Insurance Insurance { get; set; }
        public RegisterPayment RegisterPayment { get; set; }
    }
}
