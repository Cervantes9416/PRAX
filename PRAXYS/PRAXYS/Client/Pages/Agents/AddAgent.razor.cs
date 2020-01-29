using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using PRAXYS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using PRAXYS.Client.Helpers;
using PRAXYS.Commons.Entities.Agent;
using PRAXYS.Client.Services;

namespace PRAXYS.Client.Pages.Agents
{
    public class AddAgentBase : ComponentBase
    {
        [Inject] public HttpClient Http { get; set; }
        [Inject] NavigationManager navigationManager { get; set; }
        [Inject] IService Service { get; set; }
        [Inject] IJSRuntime js { get;set; }

        [Parameter] public int CompanyID { get; set; } = 0;
        [CascadingParameter] AgentList ComponentFather { get; set; }
        protected AgentModel Agent { get; set; }

        protected override void OnInitialized()
        {
            Agent = new AgentModel();
            Agent.IssueDate = DateTime.Now;
        }

        protected async Task Crear()
        {
            /*Agent = await Http.SendJsonAsync<AgentModel>(HttpMethod.Post, "api/agents", Agent);
            if (ComponentFather != null)
            {
                ComponentFather.Centered.Toggle();
                //ComponentFather.UpdateList(Agent);
                Agent = new AgentModel();
            }
            else
            {
                NavigationManager.NavigateTo("agents/list");
            }*/

            var httpResponse = await Service.POST("api/agents", Agent);
            if (httpResponse.Error)
            {
                await js.Message("Error", "No se ha podido realizar el registro", "error");
            }
            else
            {
                await js.Message("Exito", "El registro se ha guardado de forma exitosa", "success");
                navigationManager.NavigateTo("agents/list");
            }
        }
    }
}
