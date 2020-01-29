using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using PRAXYS.Client.Helpers;
using PRAXYS.Commons.Entities.Agent;
using PRAXYS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PRAXYS.Client.Pages.Agents
{
    public class EditAgentBase : ComponentBase
    {
        [Inject] public HttpClient Http { get; set; }
        [Inject] IJSRuntime js { get; set; }
        [Inject] NavigationManager navigationManager { get; set; }
        [Parameter] public int AgentID { get; set; }
        protected AgentModel Agent { get; set; }


        protected override async Task OnInitializedAsync()
        {
            Agent = await Http.GetJsonAsync<AgentModel>($"api/agents/{AgentID}");
        }

        protected async Task Editar()
        {
            var result = await Http.PutJsonAsync<bool>($"api/agents/{AgentID}",Agent);
            if (!result)
            {
                await js.Message("Error", "No se ha podido realizar el registro", "error");
            }
            else
            {
                await js.Message("Exito", "El registro se ha creado de forma exitosa", "success");
                navigationManager.NavigateTo($"agents/detail/{Agent.ID}");
            }
        }
    }
}
