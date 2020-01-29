using PRAXYS.Commons.Entities.Endorsement;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PRAXYS.Business.Interfaces
{
    public interface IEndorsementBLC
    {
        Task<bool> CreateEndorsement(EndorsementModel model);
        Task<bool> DeleteEndorsement(int id);
        Task<List<EndorsementTypeModel>> GetAllEndorsementType();
    }
}
