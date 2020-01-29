using PRAXYS.Commons.Entities.Insurance;
using System;
using System.Collections.Generic;
using System.Text;

namespace PRAXYS.Commons.Entities.Endorsement
{
    public class ModificationEndorsementRequest
    {
        public InsuranceModel Insurance { get; set; }
        public EndorsementModel Endorsement { get; set; }
    }
}
