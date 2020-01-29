using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using PRAXYS.Client.Helpers;
using PRAXYS.Commons.Entities.SubAgent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PRAXYS.Client.Pages.SubAgents
{
    public class EditSubAgentBase : ComponentBase
    {
        [Inject] HttpClient Http { get; set; }
        [Inject] IJSRuntime js { get; set; }
        [Inject] NavigationManager navigationManager { get; set; }
        [Parameter] public int SubAgentID { get; set; }
        protected SubAgentModel SubAgent { get; set; }

        protected async override Task OnInitializedAsync()
        {
            SubAgent = await Http.GetJsonAsync<SubAgentModel>($"api/subagents/{SubAgentID}");
        }

        protected async void Edit()
        {
            var result = await Http.PutJsonAsync<bool>($"api/subagents/{SubAgentID}", SubAgent);
            if (!result)
            {
                await js.Message("Error", "No se ha podido realizar el registro", "error");
            }
            else
            {
                await js.Message("Exito", "El registro se ha creado de forma exitosa", "success");
                navigationManager.NavigateTo($"subagents/details/{SubAgent.ID}");
            }
        }
    }
}
