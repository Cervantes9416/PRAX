using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using PRAXYS.Client.Services;
using PRAXYS.Commons.Entities.BondPayment;
using PRAXYS.Client.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using PRAXYS.Commons.Entities.Bond;
using BlazorStrap;

namespace PRAXYS.Client.Pages.BondPayment
{
    public class AddBondPaymentBase : ComponentBase
    {
        [Inject] HttpClient Http { get; set; }
        [Inject] IService service { get; set; }
        [Inject] IJSRuntime js { get; set; }
        [Parameter] public int BondID { get; set; }
        [Parameter] public EventCallback DataEvent { get; set; }
        [CascadingParameter] public BSModal modal { get; set; }

        protected BondPaymentModel BondPayment { get; set; }
        protected BondModel Bond { get; set; }
        

        protected async override Task OnInitializedAsync()
        {
            BondPayment = new BondPaymentModel();
            Bond = await Http.GetJsonAsync<BondModel>($"api/bonds/{BondID}");

            if (BondID != 0)
            {
                BondPayment.BondID = BondID;
            }
        }

        protected async void Create()
        {
            var httpResponse = await service.POST("api/bonds/PostBondPayment", BondPayment);
            if (httpResponse.Error)
            {
                await js.Message("Error", "No se ha podido registrar el usuario", "error");
                if (DataEvent.HasDelegate)
                {
                    await DataEvent.InvokeAsync(null);
                }
            }
            else
            {
                modal.Hide();
                Bond = null;
                await js.Message("Exito", "El usuario se ha creado de forma exitosa", "success");
            }
        }
    }
}
