using PRAXYS.Commons.Entities.Client;
using PRAXYS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PRAXYS.Business.Interfaces
{
    public interface IClientBLC
    {
        Task<ClientModel> Delete(int id);
        Task<ClientModel> Get(int id);
        Task<List<ClientModel>> GetAll();
        Task<ClientModel> GetByDetails(int id);
        Task<ClientModel> Post(ClientModel item);
        Task<bool> Put(int id, ClientModel item);
    }
}
