using PRAXYS.Commons.Entities.PaymentType;
using System;
using System.Collections.Generic;
using System.Text;

namespace PRAXYS.Commons.Interfaces
{
    public interface ISelectPaymentType
    {
        int PaymentTypeID { get; set; }
        PaymentTypeModel PaymentType { get; set; }
    }
}
