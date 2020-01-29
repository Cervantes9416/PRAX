using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using PRAXYS.Client.Services;
using PRAXYS.Commons.Entities.SubAgent;
using System;
using PRAXYS.Client.Helpers;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PRAXYS.Client.Pages.SubAgents
{
    public class AddSubAgentBase : ComponentBase
    {
        [Inject] HttpClient Http { get; set; }
        [Inject] IJSRuntime js { get; set; }
        [Inject] IService Service { get; set; }
        [Inject] NavigationManager navigationManager { get; set; }
        protected SubAgentModel SubAgent { get; set; } = new SubAgentModel();

        protected override void OnInitialized()
        {
            SubAgent.IssueDate = DateTime.Now;
            SubAgent.Status = true;
        }

        protected async Task Create()
        {
            var httpResponse = await Service.POST("api/subagents", SubAgent);
            if (httpResponse.Error)
            {
                await js.Message("Error", "No se ha podido realizar el registro", "error");
            }
            else
            {
                await js.Message("Exito", "El usregistro se ha creado de forma exitosa", "success");
                navigationManager.NavigateTo("/subagents/list");
            }
        }       
    }
}
