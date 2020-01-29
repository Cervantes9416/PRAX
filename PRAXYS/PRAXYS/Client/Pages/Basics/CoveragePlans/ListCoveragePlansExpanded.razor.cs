using Microsoft.AspNetCore.Components;
using PRAXYS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PRAXYS.Client.Pages.Basics.CoveragePlans
{
    public class ListCoveragePlansExpandedBase : ComponentBase
    {
        [Inject] HttpClient Http { get; set; }
        [Parameter] public int RamoID { get; set; }
        public List<CoveragePlan> CoveragePlans { get; set; } = new List<CoveragePlan>();

        protected override async Task OnInitializedAsync()
        {
            CoveragePlans = await Http.GetJsonAsync<List<CoveragePlan>>($"api/coverageplans/GetCoveragePlanByRamo/{RamoID}");
        }

        public async void UpdateList(CoveragePlan coveragePlan)
        {
            CoveragePlans.Add(coveragePlan);
        }
    }
}
