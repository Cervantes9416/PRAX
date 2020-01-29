using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PRAXYS.Shared.Entities
{
    public class BondPayment
    {
        public int ID { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }
        public int UserEditedID { get; set; }
        [Required]
        public DateTime DateEdited { get; set; }
        [Required]
        public int BondID { get; set; }
        [Required]
        public DateTime PayedDate { get; set; }
        [Required]
        public decimal PremiumPayed { get; set; }
        [Required]
        public bool CommissionPayed { get; set; }
        [Required]
        public int LiquidationNumber { get; set; }
        public string Status { get; set; }

        public Bond Bond { get; set; }
        public List<CommissionPayment> CommissionPayments { get; set; }
    }
}
