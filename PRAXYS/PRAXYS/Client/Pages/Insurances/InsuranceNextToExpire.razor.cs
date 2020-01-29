using Microsoft.AspNetCore.Components;
using PRAXYS.Commons.Entities;
using PRAXYS.Commons.Entities.Insurance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PRAXYS.Client.Pages.Insurances
{
    public class InsuranceNextToExpireBase : ComponentBase
    {
        [Inject] HttpClient Http { get; set; }
        [Inject] NavigationManager navigationManager { get; set; }
        [Parameter] public DatePickerModel DatePicker { get; set; }
        protected List<InsuranceCardModel> Insurances { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Insurances = await Http.SendJsonAsync<List<InsuranceCardModel>>(HttpMethod.Post ,"api/insurance/GetInsuranceNextToExpire",DatePicker);
        }

        protected override async Task OnParametersSetAsync()
        {
            Insurances = await Http.SendJsonAsync<List<InsuranceCardModel>>(HttpMethod.Post, "api/insurance/GetInsuranceNextToExpire", DatePicker);
        }

        protected void ToList()
        {
            navigationManager.NavigateTo("insurance/near");
        }

    }
}
