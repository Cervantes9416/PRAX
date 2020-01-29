using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using PRAXYS.Client.Helpers;
using PRAXYS.Commons.Entities.Client;
using PRAXYS.Commons.Entities.Insurance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PRAXYS.Client.Pages.Client
{
    public class DetailClientBase : ComponentBase
    {
        [Inject] HttpClient Http { get; set; }
        [Inject] IJSRuntime js { get; set; }
        [Parameter] public int ClientID { get; set; }
        protected ClientModel Client { get; set; }
        protected ClientDocumentationModel ClientDocumentation { get; set; } = new ClientDocumentationModel();
        protected List<InsuranceListModel> ClientInsurances { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Client = await Http.GetJsonAsync<ClientModel>($"api/clients/GetByDetails/{ClientID}");
            ClientInsurances = await Http.GetJsonAsync<List<InsuranceListModel>>($"api/insurance/GetAllByClientID/{Client.ID}");
        }

        protected async void UploadFile()
        {
            ClientDocumentation.ClientID = Client.ID;
            await Http.SendJsonAsync(HttpMethod.Post, "api/ClientDocumentation", ClientDocumentation);
            Client.ClientDocumentation = null;
            
            Client.ClientDocumentation = await Http.GetJsonAsync<List<ClientDocumentationModel>>($"api/ClientDocumentation/GetAllByID/{Client.ID}");
            StateHasChanged();
        }

        protected async void DeleteFile(int id)
        {
            await Http.DeleteAsync($"api/ClientDocumentation/{id}");
            Client.ClientDocumentation = await Http.GetJsonAsync<List<ClientDocumentationModel>>($"api/InsuranceDocumentation/GetAllByID/{id}");
            StateHasChanged();
        }

        protected async void DownloadFile(int id)
        {
            var document = await Http.GetJsonAsync<ClientDocumentationModel>($"api/ClientDocumentation/DownloadFile/{id}");
            await js.Redirect(document.Url);
            StateHasChanged();
        }

        protected async void ViewFile(int id)
        {
            var document = await Http.GetJsonAsync<ClientDocumentationModel>($"api/ClientDocumentation/ViewFile/{id}");
            await js.RedirectNewTab(document.Url);
            StateHasChanged();
        }
    }
}
