using PRAXYS.Commons.Entities.BondPayment;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PRAXYS.Business.Interfaces
{
    public interface IBondPayment : IGenericBLC<BondPaymentModel>
    {
        Task<bool>Post(BondPaymentModel item);
    }
}
