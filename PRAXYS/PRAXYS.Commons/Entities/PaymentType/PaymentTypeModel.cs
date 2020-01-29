using System;
using System.Collections.Generic;
using System.Text;

namespace PRAXYS.Commons.Entities.PaymentType
{
    public class PaymentTypeModel
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public int TotalPayments { get; set; }
    }
}
