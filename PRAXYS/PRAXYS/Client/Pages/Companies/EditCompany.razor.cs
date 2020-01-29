using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using PRAXYS.Client.Helpers;
using PRAXYS.Commons.Entities.Company;
using PRAXYS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PRAXYS.Client.Pages.Companies
{
    public class EditCompanyBase : ComponentBase
    {
        [Inject] HttpClient Http { get; set; }
        [Inject] IJSRuntime js { get; set; }
        [Inject] NavigationManager navigationManager { get; set; }
        [Parameter] public int CompanyID { get; set; }
        protected CompanyModel Company;


        protected override async Task OnInitializedAsync()
        {
            Company = await Http.GetJsonAsync<CompanyModel>($"api/companies/GetByDetails/{CompanyID}");

        }

        protected async Task Editar()
        {
            var result = await Http.PutJsonAsync<bool>($"api/companies/{Company.ID}", Company);
            if (!result)
            {
                await js.Message("Error", "No se ha podido realizar el registro", "error");
            }
            else
            {
                await js.Message("Exito", "El registro se ha creado de forma exitosa", "success");
                navigationManager.NavigateTo($"companies/detail/{Company.ID}");
            }
        }
    }
}
