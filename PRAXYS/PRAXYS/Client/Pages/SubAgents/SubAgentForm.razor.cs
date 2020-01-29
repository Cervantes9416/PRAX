using Microsoft.AspNetCore.Components;
using PRAXYS.Commons.Entities.SubAgent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRAXYS.Client.Pages.SubAgents
{
    public class SubAgentFormBase : ComponentBase
    {
        [Parameter] public SubAgentModel SubAgent { get; set; }
        [Parameter] public EventCallback OnValidSubmit { get; set; }
        [Parameter] public bool ReadOnly { get; set; }
    }
}
