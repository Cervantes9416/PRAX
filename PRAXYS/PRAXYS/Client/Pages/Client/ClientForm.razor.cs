using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using PRAXYS.Client.Intefaces;
using PRAXYS.Client.Shared.Forms;
using PRAXYS.Commons.Entities.Address;
using PRAXYS.Commons.Entities.Client;
using PRAXYS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using PRAXYS.Client.Helpers;

namespace PRAXYS.Client.Pages.Client
{
    public class ClientFormBase : ComponentBase, IAddressList
    {
        [Inject] HttpClient Http { get; set; }
        [Inject] NavigationManager navigationManager { get; set; }
        [Inject] IJSRuntime js { get; set; }

        protected string IssueDate;
        [Parameter] public ClientModel Client { get; set; }
        [Parameter] public EventCallback OnValidSubmit { get; set; }
        [Parameter] public bool ReadOnly {get;set;}
        protected AddAddress AddressForm { get; set; }
        public List<AddressModel> AddressList { get; set; }

        protected override async Task OnInitializedAsync()
        {
            AddressList = Client.ClientAddresses.Select(x => x.Address).ToList();
        }

        protected async void Alert()
        {
            await js.InvokeAsync<bool>("AlertTest");
        }

        public void OnValidSubmitCreate()
        {
            Client.ClientAddresses = AddressList
                .Select(x => new ClientAddressModel { Address = x })
                .ToList();

            OnValidSubmit.InvokeAsync(null);
        }

        protected async override Task OnAfterRenderAsync(bool firstRender)
        {
            if (ReadOnly)
            {
                await js.AddAttribute("readonly");
            }
        }
    }
}
