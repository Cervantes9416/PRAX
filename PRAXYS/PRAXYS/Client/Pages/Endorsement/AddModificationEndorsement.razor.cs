using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRAXYS.Client.Pages.Endorsement
{
    public class AddModificationEndorsementBase : ComponentBase
    {
        [Parameter] public int InsuranceID { get; set; }
        protected int EndorsementType { get; set; } = 1;
    }
}
