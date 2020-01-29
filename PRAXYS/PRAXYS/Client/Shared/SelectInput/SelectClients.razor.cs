using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using PRAXYS.Client.Helpers;
using PRAXYS.Commons.Entities.Client;
using PRAXYS.Commons.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PRAXYS.Client.Shared.SelectInput
{
    public class SelectClientsBase : ComponentBase
    {
        [Inject] public HttpClient Http { get; set; }
        [Inject] IJSRuntime js { get; set; }
        [Parameter] public ISelectClient SelectClient{ get; set; }
        [Parameter] public EventCallback<int> SendId { get; set; }
        protected List<ClientModel> Clients { get; set; }
        protected int _clientID { 
            get 
            {
                return SelectClient.ClientID;    
            }
            set 
            {
                SelectClient.ClientID = value;
                SendClientID();
            } 
        }


        protected async override Task OnInitializedAsync()
        {
            Clients = await Http
                .GetJsonAsync<List<ClientModel>>("api/clients");
        }

        protected async override Task OnAfterRenderAsync(bool firstRender)
        {
            await js.Select2Init();
        }

        private async void SendClientID()
        {
            await SendId.InvokeAsync(SelectClient.ClientID);
        }
    }
}
