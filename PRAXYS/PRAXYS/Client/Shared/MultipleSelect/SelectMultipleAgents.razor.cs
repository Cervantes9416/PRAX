using Microsoft.AspNetCore.Components;
using PRAXYS.Client.Helpers;
using PRAXYS.Commons.Entities.Agent;
using PRAXYS.Commons.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PRAXYS.Client.Shared.MultipleSelect
{
    public class SelectMultipleAgentsBase : ComponentBase
    {
        [Inject] HttpClient http { get; set; }
        [Parameter] public ReportFilterModel ReportFilter { get; set; }
        protected List<MultipleSelectModel> SelectedItems { get; set; } = new List<MultipleSelectModel>();
        protected List<MultipleSelectModel> ItemsNotSelected { get; set; }
        protected List<AgentModel> Agents { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Agents = await http.GetJsonAsync<List<AgentModel>>("api/agents");
            ItemsNotSelected = Agents
                .Select(x => new MultipleSelectModel(x.ID.ToString(), GetAgentName(x)))
                .ToList();

            StateHasChanged();
        }

        private string GetAgentName(AgentModel agent)
        {
            if (agent.PersonType == "Fisica")
            {
                return $"{agent.Name} {agent.LastName} {agent.SecondLastName}";
            }
            else
            {
                return $"{agent.CompanyName}";
            }
        }

        protected void SaveSelection()
        {
            ReportFilter.Agents = SelectedItems
                .Select(x => int.Parse(x.Key))
                .ToList();

            StateHasChanged();
        }
    }
}
