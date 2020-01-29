using PRAXYS.Commons.Entities.PaymentType;
using PRAXYS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PRAXYS.Business.Interfaces
{
    public interface IPaymentTypeBLC : IGenericBLC<PaymentTypeModel>
    {
        System.Threading.Tasks.Task<bool> DeletePayment(int id);
    }
}
