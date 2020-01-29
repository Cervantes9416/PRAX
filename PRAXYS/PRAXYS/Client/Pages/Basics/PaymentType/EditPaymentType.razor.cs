using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using PRAXYS.Client.Helpers;
using PRAXYS.Commons.Entities.PaymentType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PRAXYS.Client.Pages.Basics.PaymentType
{
    public class EditPaymentTypeBase : ComponentBase
    {
        [Inject] HttpClient Http { get; set; }
        [Inject] IJSRuntime js { get; set; }
        [Parameter] public int PaymentID { get; set; }
        protected PaymentTypeModel PaymentType { get; set; }

        protected async override Task OnInitializedAsync()
        {
            PaymentType = await Http.GetJsonAsync<PaymentTypeModel>($"api/basics/GetPaymentType/{PaymentID}");
        }

        protected async Task Edit()
        {
            var result = await Http.PutJsonAsync<bool>("api/basics/", PaymentType);
            if (!result)
            {
                await js.Message("Error", "No se ha podido realizar el registro", "error");
            }
            else
            {
                await js.Message("Exito", "El registro se ha guardado de forma exitosa", "success");
            }
        }
    }
}
