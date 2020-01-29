using PRAXYS.Commons.Entities.ComissionPayment;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PRAXYS.Business.Interfaces
{
    public interface IComissionPaymentBLC : IGenericBLC<ComissionPaymentModel>
    {
        Task<bool> CreateComissionPayment(ComissionPaymentModel item);
    }
}
