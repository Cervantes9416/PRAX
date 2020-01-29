using Microsoft.AspNetCore.Components;
using PRAXYS.Commons.Entities.Company;
using PRAXYS.Commons.Entities.Insurance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PRAXYS.Client.Pages.Companies
{
    public class DetailCompanyBase : ComponentBase
    {
        [Inject] HttpClient Http { get; set; }
        [Parameter] public int CompanyID { get; set; }
        protected  CompanyModel Company { get; set; }
        protected List<InsuranceListModel> Companies { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Company = await Http.GetJsonAsync<CompanyModel>($"api/companies/{CompanyID}");
            Companies = await Http.GetJsonAsync<List<InsuranceListModel>>($"api/insurance/GetAllByCompanyID/{CompanyID}");
        }
    }
}
