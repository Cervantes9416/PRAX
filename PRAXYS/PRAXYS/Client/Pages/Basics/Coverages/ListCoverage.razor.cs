using BlazorStrap;
using Microsoft.AspNetCore.Components;
using PRAXYS.Commons.Entities;
using PRAXYS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PRAXYS.Client.Pages.Basics.Coverages
{
    public class ListCoverageBase : ComponentBase
    {
        [Inject] HttpClient Htpp { get; set; }
        public List<CoverageModel> Coverages { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Coverages = await Htpp.GetJsonAsync<List<CoverageModel>>("api/coverages/GetAllByDetails");
        }
        
        protected void OnDblClick()
        {
            
        }

        public async void UpdateList(Coverage coverage)
        {
            Coverages = null;
            StateHasChanged();
            Coverages = await Htpp.GetJsonAsync<List<CoverageModel>>("api/coverages/GetAllByDetails");
            StateHasChanged();
        }
    }
}
