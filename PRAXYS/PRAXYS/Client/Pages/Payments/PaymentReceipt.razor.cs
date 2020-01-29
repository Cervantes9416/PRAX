using Microsoft.AspNetCore.Components;
using PRAXYS.Commons.Entities.PaymentInformation;
using PRAXYS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PRAXYS.Client.Pages.Payments
{
    public class PaymentReceiptBase : ComponentBase
    {
        [Inject] HttpClient Http { get; set; }
        [Parameter] public int PaymentID { get; set; }
        protected PaymentInformationModel Payment { get; set; }
        protected bool PayReceipt { get; set; } = true;
        protected async override Task OnInitializedAsync()
        {
            Payment = await Http
                .GetJsonAsync<PaymentInformationModel>($"api/PaymentInformation/{PaymentID}");
        }
    }
}
