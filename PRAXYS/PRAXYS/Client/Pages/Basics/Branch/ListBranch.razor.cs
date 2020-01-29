using BlazorStrap;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using PRAXYS.Client.Helpers;
using PRAXYS.Commons.Entities.Branch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PRAXYS.Client.Pages.Basics.Branch
{
    public class ListBranchBase : ComponentBase
    {
        [Inject] HttpClient Http { get; set; }
        [Inject] IJSRuntime js { get; set; }
        public BSModal Modal { get; set; }
        protected List<BranchModel> Branches { get; set; }
        protected async override Task OnInitializedAsync()
        {
            Branches = await Http.GetJsonAsync<List<BranchModel>>("api/branch/GetAllBranchs");
        }

        public async Task UpdateList()
        {
            Branches = await Http.GetJsonAsync<List<BranchModel>>("api/branch/GetAllBranchs");
            StateHasChanged();
        }

        public async Task Delete(int id)
        {
            var result = await js.ConfirmMessage("Antes de continuar", "Esta seguro de querer eliminar el registro");
            if (result)
            {
                await Http.DeleteAsync($"api/basics/DeleteBranch/{id}");
                await UpdateList();
                await js.Message("Exito", "Se ha Eliminado el registro", "success");
            }
        }
    }
}
