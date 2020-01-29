using BlazorStrap;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using PRAXYS.Client.Helpers;
using PRAXYS.Commons.Entities.Branch;
using PRAXYS.Commons.Entities.SubAgent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PRAXYS.Client.Pages.Basics.SubBranch
{
    public class ListSubBranchBase : ComponentBase
    {
        [Inject] HttpClient Http { get; set; }
        [Inject] IJSRuntime js { get; set; }
        public BSModal Modal { get; set; }
        protected List<SubBranchModel> SubBranches { get; set; }

        protected async override Task OnInitializedAsync()
        {
            SubBranches = await Http.GetJsonAsync<List<SubBranchModel>>("api/branch/GetAllSubBranch");

        }

        public async Task UpdateList()
        {
            SubBranches = await Http.GetJsonAsync<List<SubBranchModel>>("api/branch/GetAllSubBranch");
            StateHasChanged();
        }

        public async Task Delete(int id)
        {
            var result = await js.ConfirmMessage("Antes de continuar", "Esta seguro de querer eliminar el registro");
            if (result)
            {
                await Http.DeleteAsync($"api/basics/DeleteSubBranch/{id}");
                await UpdateList();
                await js.Message("Exito", "Se ha Eliminado el registro", "success");
            }

            
        }
    }
}
