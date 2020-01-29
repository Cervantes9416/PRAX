using BlazorStrap;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using PRAXYS.Client.Pages.Agents;
using PRAXYS.Commons.Entities.Agent;
using PRAXYS.Commons.Entities.Company;
using PRAXYS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using PRAXYS.Client.Helpers;

namespace PRAXYS.Client.Pages.Companies
{
    public class AddCompanyBase : ComponentBase
    {
        [Inject] IJSRuntime js { get; set; }
        [Inject] public HttpClient Http { get; set; }
        [Inject] public NavigationManager navigationManager { get; set; }
        

        protected CompanyModel Company = new CompanyModel();
        protected List<PaymentType> NotSelectPayments { get; set; } = new List<PaymentType>();
        protected List<PaymentType> SelectPayments { get; set; } = new List<PaymentType>();
        

        protected override void OnInitialized()
        {
            Company.AgentList = new List<AgentModel>();
            Company.CompanyAddress = new List<CompanyAddressModel>();
        }

        protected async Task Crear()
        {
            await Http.SendJsonAsync(HttpMethod.Post, "api/companies", Company);
            await js.Message("Exito", "El registro se ha realizado de forma exitosa", "success");
            navigationManager.NavigateTo("companies/list");
        }
        
    }
}
