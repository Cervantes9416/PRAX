using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using PRAXYS.Client.Helpers;
using PRAXYS.Client.Services;
using PRAXYS.Commons.Entities.RegisterPayment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PRAXYS.Client.Pages.Payments
{
    public class RegisterPaymentFormBase : ComponentBase
    {
        [Inject] public HttpClient Http { get; set; }
        [Inject] public IService Service { get; set; }
        [Inject] IJSRuntime js { get; set; }
        [Inject] NavigationManager navigationManager { get; set; }
        [Parameter] public int PaymentInformationID { get; set; }
        [Parameter] public int InsuranceID { get; set; }
        [Parameter] public EventCallback OnValidSubmit { get; set; }
        [Parameter] public InsurancePaymentModel InsurancePayment { get; set; }

        protected override void OnInitialized()
        {
            InsurancePayment.PaymentInformationID = PaymentInformationID;
            InsurancePayment.DatePayment = DateTime.Now;
            InsurancePayment.IssueDate = DateTime.Now;
        }
    }
}
