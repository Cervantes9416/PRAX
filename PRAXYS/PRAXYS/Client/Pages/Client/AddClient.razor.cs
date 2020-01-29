using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using PRAXYS.Client.Services;
using PRAXYS.Commons.Entities.Client;
using PRAXYS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using PRAXYS.Client.Helpers;
using Microsoft.AspNetCore.Authorization;
using PRAXYS.Client.Auth;

namespace PRAXYS.Client.Pages.Client
{
    [Authorize]
    public class AddClientBase : ComponentBase
    {
        [Inject] IJSRuntime js { get; set; }
        [Inject] public HttpClient Http { get; set; }
        [Inject] public IService Service { get; set; }
        [Inject] public NavigationManager navigationManager { get; set; }

        protected ClientModel Client;
        protected List<Address> AddressList = new List<Address>();

        protected override void OnInitialized()
        {
            Client = new ClientModel();
            Client.PersonType = "Fisica";
            Client.ClientAddresses = new List<ClientAddressModel>();
            Client.IssueDate = DateTime.Now;
        }

        protected async Task Crear()
        {
            var httpResponse = await Service.POST("api/clients", Client);
            if (httpResponse.Error)
            {
                await js.Message("Error", "No se ha podido realizar el registro", "error");
            }
            else 
            {
                await js.Message("Exito", "Se ha realizado el registro", "success");
                navigationManager.NavigateTo("/clients/list");
            }
        }

        protected void AddAddress(Address address)
        {
            
        }

        
    }
}
