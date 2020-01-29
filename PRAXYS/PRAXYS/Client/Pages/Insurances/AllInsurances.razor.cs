using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using PRAXYS.Commons.Entities;
using PRAXYS.Commons.Entities.Client;
using PRAXYS.Commons.Entities.Company;
using PRAXYS.Commons.Entities.Insurance;
using PRAXYS.Commons.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PRAXYS.Client.Pages.Insurances
{
    public class AllInsurancesBase : ComponentBase
    {
        [Inject] HttpClient Http { get; set; }
        
        [Parameter] public string origin { get; set; }
        protected List<InsuranceListModel> InsuranceList { get; set; }
        protected InsuranceFilter InsuranceFilter { get; set; } = new InsuranceFilter(); 
        protected List<ClientModel> Clients { get; set; }
        protected List<CompanyModel> Companies { get; set; }

        protected override async Task OnInitializedAsync()
        {
            //InsuranceList = await Http.GetJsonAsync<List<InsuranceListModel>>("api/insurance/GetListModels");
            InsuranceList = await Http.GetJsonAsync<List<InsuranceListModel>>("api/insurance/GetAllWithoutEndorsement");
            Clients = InsuranceList
                .Select(x => x.Client)
                .Distinct()
                .ToList();

            Companies = InsuranceList
                .Distinct()
                .Select(x => x.Company)
                .ToList();
        }

        protected async void FilterValues() 
        {
            InsuranceList = await Http.SendJsonAsync<List<InsuranceListModel>>(HttpMethod.Post, "api/Insurance/GetAllByFilter", InsuranceFilter);
            StateHasChanged();
        }
    }
}
