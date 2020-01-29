using PRAXYS.Commons.Entities.ComissionPayment;
using System;
using System.Collections.Generic;
using System.Text;

namespace PRAXYS.Commons.Entities.BondPayment
{
    public class BondPaymentModel
    {
        public int ID { get; set; }
        public DateTime DateCreated { get; set; }
        public int UserEditedID { get; set; }
        public DateTime DateEdited { get; set; }
        public int BondID { get; set; }

        public DateTime? PayedDate { get; set; }
        public decimal PremiumPayed { get; set; }
        public bool CommissionPayed { get; set; }
        public int LiquidationNumber { get; set; }
        public string Status { get; set; }

        public List<ComissionPaymentModel> CommissionPayments { get; set; }
    }
}
