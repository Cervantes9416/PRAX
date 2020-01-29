using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using PRAXYS.Client.Helpers;
using PRAXYS.Commons.Entities.Agent;
using PRAXYS.Commons.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PRAXYS.Client.Shared.SelectInput
{
    public class SelectAgentBase : ComponentBase
    {
        [Inject] HttpClient Http { get; set; }
        [Inject] IJSRuntime js { get; set; }
        [Parameter] public ISelectAgent SelectAgent { get; set; }
        protected List<AgentModel> Agents { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Agents = await Http.GetJsonAsync<List<AgentModel>>("api/agents");
        }

        protected async override Task OnAfterRenderAsync(bool firstRender)
        {
            await js.Select2Init();
        }

    }
}
