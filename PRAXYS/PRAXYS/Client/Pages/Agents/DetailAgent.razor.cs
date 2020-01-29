using Microsoft.AspNetCore.Components;
using PRAXYS.Commons.Entities.Agent;
using PRAXYS.Commons.Entities.Insurance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PRAXYS.Client.Pages.Agents
{
    public class DetailAgentBase : ComponentBase
    {
        [Inject] HttpClient Http { get; set; }
        [Parameter] public int AgentID { get; set; }
        protected AgentModel Agent { get; set; } 
        protected List<InsuranceListModel> AgentInsurances { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Agent = await Http.GetJsonAsync<AgentModel>($"api/agents/{AgentID}");
            AgentInsurances = await Http.GetJsonAsync<List<InsuranceListModel>>($"api/insurance/GetAllByAgentID/{AgentID}");
        }
    }
}
