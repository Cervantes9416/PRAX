using PRAXYS.Commons.Entities.BondPayment;
using System;
using System.Collections.Generic;
using System.Text;

namespace PRAXYS.Commons.Entities.ComissionPayment
{
    public class ComissionPaymentModel
    {
        public int ID { get; set; }
        public DateTime DateCrated { get; set; }
        public int UserEditedID { get; set; }
        public DateTime DateEdited { get; set; }

        public int BondPaymentID { get; set; }
        public DateTime? PayedDate { get; set; }
        public decimal AmountPayed { get; set; }

        public BondPaymentModel BondPayment { get; set; }
    }
}
