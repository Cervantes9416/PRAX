using Microsoft.AspNetCore.Components;
using PRAXYS.Commons.Entities.Branch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRAXYS.Client.Pages.Basics.Branch
{
    public class FormBranchBase : ComponentBase
    {
        [Parameter] public EventCallback OnValidSubmit { get; set; }
        [Parameter] public BranchModel Branch { get; set; }

    }
}
