using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using PRAXYS.Client.Helpers;
using PRAXYS.Commons.Entities.Company;
using PRAXYS.Commons.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PRAXYS.Client.Shared.SelectInput
{
    public class SelectCompanyBase : ComponentBase
    {
        [Inject] HttpClient Http { get; set; }
        [Inject] IJSRuntime js { get; set; }
        [Parameter] public ISelectCompany SelectCompany { get; set; }
        protected List<CompanyModel> Companies {get;set;}

        protected async override Task OnInitializedAsync()
        {
            Companies = await Http.GetJsonAsync<List<CompanyModel>>("api/companies");
        }

        protected async override Task OnAfterRenderAsync(bool firstRender)
        {
            await js.Select2Init();
        }

    }
}
