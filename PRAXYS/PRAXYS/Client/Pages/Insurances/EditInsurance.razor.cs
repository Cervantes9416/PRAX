using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using PRAXYS.Client.Helpers;
using PRAXYS.Commons.Entities.Insurance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PRAXYS.Client.Pages.Insurances
{
    public class EditInsuranceBase : ComponentBase
    {
        [Inject] HttpClient Http {get;set;}
        [Inject] IJSRuntime js { get; set; }
        [Inject] NavigationManager navigationManager { get; set; }
        [Parameter] public int BranchID { get; set; }
        [Parameter] public int InsuranceID { get; set; }
        protected InsuranceModel Insurance { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Insurance = await Http.GetJsonAsync<InsuranceModel>($"api/Insurance/GetByDetails/{InsuranceID}");
        }

        protected async void Edit()
        {
            try
            {
                var result = await Http.PutJsonAsync<bool>($"api/Insurance/{InsuranceID}", Insurance);
                if (!result)
                {
                    await js.Message("Error", "No se ha podido realizar el registro", "error");
                }
                else
                {
                    await js.Message("Exito", "El registro se ha creado de forma exitosa", "success");
                    navigationManager.NavigateTo($"insurance/{InsuranceID}");
                }
            }
            catch (Exception)
            {
                await js.Message("Error", "No se ha podido realizar el registro", "error");
            } 
        }
    }
}
