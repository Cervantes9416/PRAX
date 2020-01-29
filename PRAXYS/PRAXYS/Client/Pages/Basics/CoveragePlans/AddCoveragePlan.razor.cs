using Microsoft.AspNetCore.Components;
using PRAXYS.Commons.Entities;
using PRAXYS.Commons.Entities.CoveragePlan;
using PRAXYS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PRAXYS.Client.Pages.Basics.CoveragePlans
{
    public class AddCoveragePlanBase : ComponentBase
    {
        [Inject] HttpClient Http { get; set; }
        [CascadingParameter] public ListCoveragePlansExpandedBase List { get; set; }
        protected CoveragePlanModel CoveragePlan = new CoveragePlanModel();

        protected List<CoverageModel> ListCoverageNoSelect { get; set; }
        protected List<CoverageModel> ListCoverageSelect { get; set; }

        protected override void OnInitialized()
        {
            ListCoverageNoSelect = new List<CoverageModel>();
            ListCoverageSelect = new List<CoverageModel>();
        }

        protected async Task Create()
        {
            var coveragePlan = await Http.SendJsonAsync<CoveragePlan>(HttpMethod.Post, "api/coverageplans", CoveragePlan);
            if (List != null)
            {
                List.UpdateList(coveragePlan);
            }
        }
    }
}
