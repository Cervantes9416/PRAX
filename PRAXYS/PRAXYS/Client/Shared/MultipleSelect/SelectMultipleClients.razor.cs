using Microsoft.AspNetCore.Components;
using PRAXYS.Client.Helpers;
using PRAXYS.Commons.Entities.Client;
using PRAXYS.Commons.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PRAXYS.Client.Shared.MultipleSelect
{
    public class SelectMultipleClientsBase : ComponentBase
    {
        [Inject] HttpClient http { get; set; }
        protected List<MultipleSelectModel> SelectedItems { get; set; } = new List<MultipleSelectModel>();
        [Parameter] public ReportFilterModel ReportFilter { get; set; }
        protected List<MultipleSelectModel> ItemsNotSelected { get; set; } 
        protected List<ClientModel> Clients { get; set; }

        protected async override void OnInitialized()
        {
            Clients = await http.GetJsonAsync<List<ClientModel>>("api/clients");
            ItemsNotSelected = Clients
                .Select(x => new MultipleSelectModel(x.ID.ToString(), GetClientName(x)))
                .ToList();

            StateHasChanged();
        }

        private string GetClientName(ClientModel client)
        {
            if (client.PersonType == "Fisica")
            {
                return $"{client.Name} {client.LastName} {client.SecondLastName}";
            }
            else
            {
                return $"{client.CompanyName}";
            }
        }
         
        protected void SaveSelection()
        {
            ReportFilter.Clients = SelectedItems
                .Select(x => int.Parse(x.Key))
                .ToList();

            StateHasChanged();
        }
    }
}
