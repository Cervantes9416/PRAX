using PRAXYS.Commons.Entities.Branch;
using System;
using System.Collections.Generic;
using System.Text;

namespace PRAXYS.Commons.Interfaces
{
    public interface ISelectSubBranch
    {
        int SubBranchID { get; set; }
        SubBranchModel SubBranch { get; set; }
    }
}
