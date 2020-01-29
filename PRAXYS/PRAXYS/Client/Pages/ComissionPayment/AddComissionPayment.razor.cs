using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using PRAXYS.Client.Services;
using PRAXYS.Commons.Entities.ComissionPayment;
using PRAXYS.Client.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRAXYS.Client.Pages.ComissionPayment
{
    public class AddComissionPaymentBase : ComponentBase
    {
        [Inject] IJSRuntime js { get; set; }
        [Inject] IService service { get; set; }
        [Parameter] public int BondPaymentID { get; set; }
        protected ComissionPaymentModel ComissionPayment { get; set; }

        protected override void OnInitialized()
        {
            ComissionPayment = new ComissionPaymentModel();
            ComissionPayment.BondPaymentID = BondPaymentID;
        }

        protected async void Create()
        {
            var httpResponse = await service.POST("api/bonds/PostComissionPayment", ComissionPayment);
            if (httpResponse.Error)
            {
                await js.Message("Error", "No se ha podido registrar el usuario", "error");
            }
            else
            {
                await js.Message("Exito", "El usuario se ha creado de forma exitosa", "success");
            }
        }
    }
}
