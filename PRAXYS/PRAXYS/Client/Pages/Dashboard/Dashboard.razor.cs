using Microsoft.AspNetCore.Components;
using PRAXYS.Commons.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PRAXYS.Client.Pages.Dashboard
{
    public class DashboardBase : ComponentBase
    {
        [Inject] HttpClient Http { get; set; }

        protected DateTime? InitialDate { get; set; }
        protected DateTime? FinalDate { get; set; }
        protected DatePickerModel DatePicker { get; set; }
        private string _dateRange { get; set; }
        protected string DateRange { get { return _dateRange; } 
            set {
                _dateRange = value;
                SelectDate();
            } 
        }

        protected override void OnInitialized()
        {
            DatePicker = new DatePickerModel();
            DatePicker.InitalDate = DateTime.Today.Date;
            DatePicker.FinalDate = DatePicker.InitalDate.Value.AddMonths(1);
            _dateRange = "MES";
        }

        protected void SelectDate() 
        {
            switch (DateRange)
            {
                case "MES":
                    DatePicker.InitalDate = DateTime.Today.Date;
                    DatePicker.FinalDate = DatePicker.InitalDate.Value.AddMonths(1);
                    break;
                case "TRIMESTRE":
                    DatePicker.InitalDate = DateTime.Today.Date;
                    DatePicker.FinalDate = DatePicker.InitalDate.Value.AddMonths(3);
                    break;
                case "SEMESTRE":
                    DatePicker.InitalDate = DateTime.Today.Date;
                    DatePicker.FinalDate = DatePicker.InitalDate.Value.AddMonths(6);
                    break;
                case "ANUAL":
                    DatePicker.InitalDate = DateTime.Today.Date;
                    DatePicker.FinalDate = DatePicker.InitalDate.Value.AddYears(1);
                    break;
            }
            StateHasChanged();
        }
    }
}
