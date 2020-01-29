using Microsoft.AspNetCore.Components;
using PRAXYS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PRAXYS.Client.Pages.Basics.CoveragePlans
{
    public class ListCoveragePlansBase : ComponentBase
    {
        [Inject] HttpClient Http { get; set; }
        public List<CoveragePlan> CoveragePlans { get; set; } = new List<CoveragePlan>();
        [Parameter] public EventCallback<int> OnDblClick { get; set; }

        protected override async Task OnInitializedAsync()
        {
            CoveragePlans = await Http.GetJsonAsync<List<CoveragePlan>>("api/coverageplans");
        }

        public async void UpdateList(CoveragePlan coveragePlan)
        {
            CoveragePlans.Add(coveragePlan);
            StateHasChanged();
        }
    }
}
