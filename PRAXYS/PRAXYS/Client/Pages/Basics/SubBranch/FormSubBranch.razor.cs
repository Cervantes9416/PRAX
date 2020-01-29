using Microsoft.AspNetCore.Components;
using PRAXYS.Commons.Entities.Branch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRAXYS.Client.Pages.Basics.SubBranch
{
    public class FormSubBranchBase : ComponentBase
    {
        [Parameter] public SubBranchModel SubBranch { get; set; }
        [Parameter] public EventCallback OnValidSubmit { get; set; }
    }
}
