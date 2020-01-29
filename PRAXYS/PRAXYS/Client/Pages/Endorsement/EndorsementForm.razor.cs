using Microsoft.AspNetCore.Components;
using PRAXYS.Commons.Entities.Endorsement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRAXYS.Client.Pages.Endorsement
{
    public class EndorsementFormBase : ComponentBase
    {
        [Parameter] public EndorsementModel Endorsement { get; set; }
        [Parameter] public EventCallback OnValidSubmit { get; set; }
    }
}
