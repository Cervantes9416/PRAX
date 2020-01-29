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
    public class InsuranceNearToExpireBase : ComponentBase
    {
        [Inject] HttpClient Http { get; set;}
        //[Parameter] public string search { get; set; }
        protected List<InsuranceListModel> InsuranceList { get; set; }
        protected InsuranceFilter InsuranceFilter { get; set; } = new InsuranceFilter();

        private string _dateRange { get; set; }
        protected string DateRange
        {
            get { return _dateRange; }
            set
            {
                _dateRange = value;
                SelectDate();
            }
        }

        protected override async Task OnInitializedAsync()
        {
            DateRange = "MES";
            InsuranceFilter.InitalDate = DateTime.Today;
            InsuranceFilter.FinalDate = InsuranceFilter.InitalDate.Value.AddMonths(1);
            InsuranceList = await Http
                .SendJsonAsync<List<InsuranceListModel>>(HttpMethod.Post, "api/Insurance/GetAllByFilter", InsuranceFilter);
        }

        protected async void SelectDate()
        {
            switch (DateRange)
            {
                case "MES":
                    InsuranceFilter.InitalDate = DateTime.Today.Date;
                    InsuranceFilter.FinalDate = InsuranceFilter.InitalDate.Value.AddMonths(1);
                    break;
                case "TRIMESTRE":
                    InsuranceFilter.InitalDate = DateTime.Today.Date;
                    InsuranceFilter.FinalDate = InsuranceFilter.InitalDate.Value.AddMonths(3);
                    break;
                case "SEMESTRE":
                    InsuranceFilter.InitalDate = DateTime.Today.Date;
                    InsuranceFilter.FinalDate = InsuranceFilter.InitalDate.Value.AddMonths(6);
                    break;
                case "ANUAL":
                    InsuranceFilter.InitalDate = DateTime.Today.Date;
                    InsuranceFilter.FinalDate = InsuranceFilter.InitalDate.Value.AddYears(1);
                    break;
            }

            InsuranceList = await Http
                .SendJsonAsync<List<InsuranceListModel>>(HttpMethod.Post, "api/Insurance/GetAllByFilter", InsuranceFilter);
            StateHasChanged();
        }
    }
}
