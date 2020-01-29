using Microsoft.AspNetCore.Components;
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
        protected string InsuranceNumber { get; set; }
        protected List<PaymentInformationModel> Payments { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Payments = await Http
                .GetJsonAsync<List<PaymentInformationModel>>($"api/paymentInformation/GetPaymentWithInsuranceNumber/{InsuranceNumber}");
        }
    }
}
