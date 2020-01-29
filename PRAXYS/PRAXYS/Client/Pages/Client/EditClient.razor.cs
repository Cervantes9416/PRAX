using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using PRAXYS.Client.Helpers;
using PRAXYS.Commons.Entities.Client;
using PRAXYS.Commons.Interfaces;
using PRAXYS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using W8lessLabs.Blazor.LocalFiles;

namespace PRAXYS.Client.Pages.Client
{
    public class EditClientBase : ComponentBase
    {
        [Inject] public HttpClient Http { get; set; }
        [Inject] IJSRuntime js { get; set; }
        [Inject] public NavigationManager navigationManager { get; set; }
        [Parameter] public int id { get; set; }
        protected ClientModel Client { get; set; }
        protected ClientDocumentationModel ClientDocumentation { get; set; } = new ClientDocumentationModel();
        protected List<ClientDocumentationModel> ClientDocumentationList { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Client = await Http.GetJsonAsync<ClientModel>($"api/clients/GetByDetails/{id}");
            ClientDocumentationList = Client.ClientDocumentation;
        }

        protected async Task Edit()
        {
            
            try
            {
                var result = await Http.PutJsonAsync<bool>($"api/clients/{id}", Client);
                if (!result)
                {
                    await js.Message("Error", "No se ha podido realizar el registro", "error");
                }
                else
                {
                    await js.Message("Exito", "El registro se ha creado de forma exitosa", "success");
                    navigationManager.NavigateTo($"clients/details/{Client.ID}");
                }
            }
            catch (Exception)
            {
                await js.Message("Error", "No se ha podido realizar el registro", "error");
            }
        }

        protected async void UploadFile()
        {
            ClientDocumentation.ClientID = Client.ID;
            await Http.SendJsonAsync(HttpMethod.Post, "api/ClientDocumentation", ClientDocumentation);
            Client.ClientDocumentation = null;
            StateHasChanged();
            Client.ClientDocumentation = await Http.GetJsonAsync<List<ClientDocumentationModel>>($"api/ClientDocumentation/GetAllByID/{Client.ID}");
            StateHasChanged();
        }
    }
}
