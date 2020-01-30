using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using PRAXYS.Client.Helpers;
using PRAXYS.Commons.Entities.Insurance;
using PRAXYS.Commons.Entities.PaymentInformation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PRAXYS.Client.Pages.Payments
{
    public class PaymentInformationSearchBase : ComponentBase
    {
        [Inject] HttpClient Http { get; set; }
        [Inject] IJSRuntime js { get; set; }
        private string InsuranceNumber { get; set; }
        protected string _insuranceNumber 
        {
            get 
            {
                return InsuranceNumber;
            }
            set 
            {
                InsuranceNumber = value;
                
            }
        }

        protected List<PaymentInformationModel> Payments { get; set; }
        protected List<InsuranceListModel> InsuranceList { get; set; }

        protected async override Task OnInitializedAsync()
        {
            /*InsuranceList = await Http
                .GetJsonAsync<List<InsuranceListModel>>("api/insurance/GetAllWithoutEndorsement");*/
            //InsuranceNumbers = InsuranceList.Select(x => x.InsuranceNumber).ToList();
        }

        protected async Task SearchInsurance()
        {
            Payments = await Http
                .GetJsonAsync<List<PaymentInformationModel>>($"api/paymentInformation/GetAllInsurancePaymentsWithInsurance/{InsuranceNumber}");
            StateHasChanged();
        }

        protected async override Task OnAfterRenderAsync(bool firstRender)
        {
            await js.Select2Init();
        }
    }
}
