using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PRAXYS.Business.Interfaces
{
    public interface IGenericBLC<T>
    {
        Task<List<T>> GetAll();
        Task<T> Get(int id);
        Task<T> Post(T item);
        Task<T> Put(int id, T item);
        Task<T> Delete(int id);
        Task<bool> Post(Commons.Entities.BondPayment.BondPaymentModel item);
    }
}
