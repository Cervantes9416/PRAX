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
    public class DetailsInsuranceBase : ComponentBase
    {
        [Inject] HttpClient Http { get; set; }
        [Inject] IJSRuntime js { get; set; }
        [Inject] NavigationManager NavigationManager { get; set; }
        [Parameter] public int InsuranceID { get; set; }
        protected InsuranceModel Insurance { get; set; }
        protected InsuranceDocumentationModel InsuranceDocumentation { get; set; } = new InsuranceDocumentationModel();
       
        protected override async Task OnInitializedAsync()
        {
            Insurance = await Http
                .GetJsonAsync<InsuranceModel>($"api/insurance/GetByDetails/{InsuranceID}");
            
        }

        protected async void UploadFile()
        {
            InsuranceDocumentation.InsuranceID = InsuranceID;
            await Http.SendJsonAsync(HttpMethod.Post, "api/InsuranceDocumentation", InsuranceDocumentation);
            Insurance.InsuranceDocumentation = await Http.GetJsonAsync<List<InsuranceDocumentationModel>>($"api/InsuranceDocumentation/GetAllByID/{InsuranceID}");
            StateHasChanged();
        }

        protected async void DeleteFile(int id)
        {
            await Http.DeleteAsync($"api/InsuranceDocumentation/{id}");
            Insurance.InsuranceDocumentation = await Http.GetJsonAsync<List<InsuranceDocumentationModel>>($"api/InsuranceDocumentation/GetAllByID/{InsuranceID}");
            StateHasChanged();
            await js.Reload();
        }

        protected async void ViewFile(int id)
        {
            var insurance = await Http.GetJsonAsync<InsuranceDocumentationModel>($"api/InsuranceDocumentation/ViewDocument/{id}");

            //NavigationManager.NavigateTo(url);
            await js.RedirectNewTab(insurance.Url);
            
        }

        protected async void DownloadFile(int id)
        {
            var insurance  = await Http.GetJsonAsync<InsuranceDocumentationModel>($"api/InsuranceDocumentation/DownloadDocument/{id}");

            //NavigationManager.NavigateTo(url);
            await js.Redirect(insurance.Url);
        }
    }
}
