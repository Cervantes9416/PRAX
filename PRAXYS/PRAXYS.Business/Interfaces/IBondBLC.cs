using PRAXYS.Commons.Entities.Bond;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PRAXYS.Business.Interfaces
{
    public interface IBondBLC 
    {
        Task<BondModel> Get(int id);
        Task<List<BondListModel>> GetAll();
        Task<BondModel> GetWithDetails(int id);
        Task<BondModel> Post(BondModel model);
    }
}
