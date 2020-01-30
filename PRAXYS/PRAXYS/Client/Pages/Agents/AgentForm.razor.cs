using Microsoft.AspNetCore.Components;
using PRAXYS.Client.Helpers;
using PRAXYS.Client.Intefaces;
using PRAXYS.Commons.Entities.Address;
using PRAXYS.Commons.Entities.Agent;
using PRAXYS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace PRAXYS.Client.Pages.Agents
{
    public class AgentFormBase : ComponentBase, IAddressList
    {
        [Inject] public HttpClient Http { get; set; }
        [Inject] IJSRuntime js { get; set; }
        [Parameter] public AgentModel Agent { get; set; }
        [Parameter] public EventCallback OnValidSubmit { get; set; }
        [Parameter] public bool ReadOnly { get; set; }
        public List<AddressModel> AddressList { get; set; } = new List<AddressModel>();


        protected override void OnInitialized()
        {
            
        }

        protected async override Task OnAfterRenderAsync(bool firstRender)
        {
            if (ReadOnly)
            {
                await js.AddAttribute("readonly");
            }
            
        }

        public void OnValidSubmitCreate()
        {
            Agent.Agent_Addresses = AddressList
                .Select(x => new AgentAddressModel { Address = x })
                .ToList();

            OnValidSubmit.InvokeAsync(null);
        }
    }
}
