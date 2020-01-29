using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PRAXYS.Shared.Entities
{
    public class CommissionPayment
    {
        public int ID { get; set; }
        public DateTime DateCrated { get; set; }
        public int UserEditedID { get; set; }
        public DateTime DateEdited { get; set; }
        
        [Required]
        public int BondPaymentID { get; set; }
        [Required]
        public DateTime PayedDate { get; set; }
        [Required]
        public decimal AmountPayed { get; set; }

        public BondPayment BondPayment { get; set; }
    }
}
