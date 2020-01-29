using PRAXYS.Commons.Entities.Endorsement;
using System;
using System.Collections.Generic;
using System.Text;

namespace PRAXYS.Commons.Interfaces
{
    public interface ISelectEndorsementType
    {
        int EndorsementTypeID { get; set; }
        EndorsementTypeModel EndorsementType { get; set; }
    }
}
