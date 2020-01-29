using Microsoft.AspNetCore.Components;
using PRAXYS.Commons.Entities.Agent;
using PRAXYS.Commons.Entities.Client;
using PRAXYS.Commons.Entities.Company;
using PRAXYS.Commons.Entities.SubAgent;
using PRAXYS.Commons.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PRAXYS.Client.Pages.Reports
{
    public class GenerateReportBase : ComponentBase
    {
        [Inject] HttpClient Http { get; set; }
        protected ReportFilterModel ReportFilter { get; set; }
        protected string SelectedReport { get; set; } = "VIGENTES";
        private bool dateRange { get; set; }

        //--LISTADOS
        protected List<ClientModel> Clients { get; set; }
        protected List<AgentModel> Agents { get; set; }
        protected List<CompanyModel> Companies { get; set; }
        protected List<SubAgentModel> SubAgents { get; set; }

        //--SELECTED ITEMS
        protected int ClientSelected { get; set; }
        protected int AgentSelected { get; set; }
        protected int CompanySelected { 
            get { 
                return CompanySelected; 
            }
            set {
                ReportFilter.Companies.Clear();
                ReportFilter.Companies.Add(value);
                StateHasChanged();
            }
        }

        public bool DateRange
        {
            get { return dateRange; }
            set
            {
                dateRange = value;
                StateHasChanged();
            }
        }

        protected async void GenerateReport()
        {
            await Http.SendJsonAsync(HttpMethod.Post, "api/Insurance/GenerateValidReport", ReportFilter);
        }

        protected async override Task OnInitializedAsync()
        {
            ReportFilter = new ReportFilterModel();
            ReportFilter.SelectedReport = "VIGENTES";

            Clients = await Http.GetJsonAsync<List<ClientModel>>("api/clients");
            Agents = await Http.GetJsonAsync<List<AgentModel>>("api/agents");
            Companies = await Http.GetJsonAsync<List<CompanyModel>>("api/companies");
            SubAgents = await Http.GetJsonAsync<List<SubAgentModel>>("api/subagents");
        }
    }
}
