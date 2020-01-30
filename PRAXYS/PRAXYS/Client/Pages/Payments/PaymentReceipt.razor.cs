using Microsoft.AspNetCore.Components;
using PRAXYS.Client.Services;
using PRAXYS.Commons.Entities.PaymentInformation;
using PRAXYS.Shared.Entities;
using Microsoft.JSInterop;
using PRAXYS.Client.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using PRAXYS.Commons.Entities.RegisterPayment;

namespace PRAXYS.Client.Pages.Payments
{
    public class PaymentReceiptBase : ComponentBase
    {
        [Inject] HttpClient Http { get; set; }
        [Inject] public IService Service { get; set; }
        [Inject] IJSRuntime js { get; set; }
        [Inject] NavigationManager navigationManager { get; set; }
        [Parameter] public int PaymentID { get; set; }
        [Parameter] public EventCallback OnModalForm { get; set; }
        protected PaymentInformationModel Payment { get; set; }
        protected InsurancePaymentModel InsurancePayment { get; set; }
        protected bool PayReceipt { get; set; } = true;


        protected async override Task OnInitializedAsync()
        {
            Payment = await Http
                .GetJsonAsync<PaymentInformationModel>($"api/PaymentInformation/{PaymentID}");
            InsurancePayment = new InsurancePaymentModel();
        }

        protected async void RegisterPayment()
        {
            //var result = await Http.SendJsonAsync<bool>(HttpMethod.Post, "api/PaymentInformation/PayReceipt", InsurancePayment);
            var httpResponse = await Service.POST("api/PaymentInformation/PayReceipt", InsurancePayment);
            if (httpResponse.Error)
            {
                await js.Message("Error", "No se ha podido realizar el registro", "error");
            }
            else
            {
                await js.Message("Exito", "El registro se ha guardado de forma exitosa", "success");
                //navigationManager.NavigateTo($"Overview/{InsuranceID}");
                await OnModalForm.InvokeAsync(null);
            }
        }
    }
}
