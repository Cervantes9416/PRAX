using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using PRAXYS.Shared.Entities;
using PRAXYS.Commons.Entities.Company;
using Microsoft.JSInterop;
using PRAXYS.Client.Helpers;

namespace PRAXYS.Client.Pages.Companies
{
    public class CompanyListBase : ComponentBase
    {
        [Inject] HttpClient Http { get; set; } 
        [Inject] IJSRuntime js { get; set; }
        [Parameter] public EventCallback<int> OnDblClick { get; set; }

        protected List<CompanyModel> Companies { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Companies = await Http.GetJsonAsync<List<CompanyModel>>("api/companies");
        }

        protected async Task Delete(int id)
        {
            var result = await js.ConfirmMessage("Antes de continuar", "Esta seguro de querer eliminar el registro");
            if (result)
            {
                await Http.DeleteAsync($"api/companies/{id}");
                await js.Message("Exito", "Se ha Eliminado el registro", "success");
                await js.Reload();
            }
        }
    }
}
