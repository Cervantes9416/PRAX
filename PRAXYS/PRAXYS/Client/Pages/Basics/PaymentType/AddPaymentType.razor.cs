using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using PRAXYS.Client.Helpers;
using PRAXYS.Client.Services;
using PRAXYS.Commons.Entities.PaymentType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PRAXYS.Client.Pages.Basics.PaymentType
{
    public class AddPaymentTypeBase : ComponentBase
    {
        [Inject] HttpClient Http { get; set; }
        [Inject] IService Service { get; set; }
        [Inject] IJSRuntime js { get; set; }
        [Parameter] public EventCallback UpdateList { get; set; }
        [CascadingParameter] public ListPaymentType ParentContent { get; set; }
        protected PaymentTypeModel PaymentType { get; set; }


        protected override void OnInitialized()
        {
            PaymentType = new PaymentTypeModel();
        }

        protected async void Create()
        {
            var httpResponse = await Service.POST("api/basics/PostPaymentType", PaymentType);
            if (httpResponse.Error)
            {
                await js.Message("Error", "No se ha podido realizar el registro", "error");
            }
            else
            {
                await js.Message("Exito", "El registro se ha guardado de forma exitosa", "success");
                await js.Reload();
                /*if (ParentContent != null)
                {
                    ParentContent.Modal.Hide();
                    PaymentType = null;
                    await ParentContent.UpdateList();
                }*/
            }
        }

    }
}
