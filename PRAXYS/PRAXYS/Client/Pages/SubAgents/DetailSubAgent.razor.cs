using Microsoft.AspNetCore.Components;
using PRAXYS.Commons.Entities.Insurance;
using PRAXYS.Commons.Entities.SubAgent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PRAXYS.Client.Pages.SubAgents
{
    public class DetailSubAgentBase : ComponentBase
    {
        [Inject] HttpClient Http { get; set; }
        [Parameter] public int SubAgentID { get; set; }
        protected SubAgentModel SubAgent { get; set; }
        protected List<InsuranceListModel> SubAgentInsurances { get; set; }

        protected async override Task OnInitializedAsync()
        {
            SubAgent = await Http.GetJsonAsync<SubAgentModel>($"api/SubAgents/{SubAgentID}");
            SubAgentInsurances = await Http.GetJsonAsync<List<InsuranceListModel>>($"api/insurance/GetAllBySubAgentID/{SubAgentID}");
        }
    }
}
