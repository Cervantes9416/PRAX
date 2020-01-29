using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using PRAXYS.Client.Helpers;
using PRAXYS.Commons.Entities.SubAgent;
using PRAXYS.Commons.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PRAXYS.Client.Shared.SelectInput
{
    public class SelectSubAgentBase : ComponentBase
    {
        [Inject] HttpClient Http { get; set; }
        [Inject] IJSRuntime js { get; set; }
        [Parameter] public ISelectSubAgent SelectSubAgent { get; set; }
        protected List<SubAgentModel> SubAgents { get; set; }

        protected async override Task OnInitializedAsync()
        {
            SubAgents = await Http.GetJsonAsync<List<SubAgentModel>>("api/SubAgents");
        }
        protected async override Task OnAfterRenderAsync(bool firstRender)
        {
            await js.Select2Init();
        }

    }
}
