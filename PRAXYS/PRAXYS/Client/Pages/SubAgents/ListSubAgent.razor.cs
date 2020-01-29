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
    public class ListSubAgentBase : ComponentBase
    {
        [Inject] IJSRuntime js { get; set; }
        [Inject] HttpClient Http { get; set; }
        protected List<SubAgentModel> SubAgents { get; set; }

        protected override async Task OnInitializedAsync()
        {
            SubAgents = await Http.GetJsonAsync<List<SubAgentModel>>("api/subagents");
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await js.DataTableInit();
            }
        }

        protected async Task Delete(int id)
        {
            var result = await js.ConfirmMessage("Antes de continuar", "Esta seguro de querer eliminar el registro");
            if (result)
            {
                await Http.DeleteAsync($"api/SubAgents/{id}");
                await js.Message("Exito", "Se ha Eliminado el registro", "success");
                await js.Reload();
            }
        }
    }
}
