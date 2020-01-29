using BlazorStrap;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
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
    public class AgentListBase : ComponentBase
    {
        [Inject] public HttpClient Http { get; set; }
        [Inject] IJSRuntime js { get; set; }
        [Parameter] public EventCallback<int> OnDblClick { get; set; }
        [Parameter] public int CompanyID { get; set; } = 0;
        [Parameter] public List<AgentModel> AgentList { get; set; }

        protected override async Task OnInitializedAsync()
        {
            AgentList = await Http.GetJsonAsync<List<AgentModel>>("api/agents");
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await js.DataTableInit();
            }
        }

        protected  async Task Delete(int id)
        {
            var result = await js.ConfirmMessage("Antes de continuar", "Esta seguro de querer eliminar el registro");
            if (result)
            {
                await Http.DeleteAsync($"api/agents/{id}");
                //Clients = await Http.GetJsonAsync<List<ClientModel>>("api/clients");
                await js.Message("Exito", "Se ha Eliminado el registro", "success");
                await js.Reload();
            }

            //StateHasChanged();
        }
    }
}
