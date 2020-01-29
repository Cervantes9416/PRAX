using Microsoft.AspNetCore.Components;
using PRAXYS.Commons.Entities.Endorsement;
using PRAXYS.Commons.Entities.Insurance;
using PRAXYS.Client.Services;
using PRAXYS.Client.Helpers;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PRAXYS.Client.Pages.Endorsement
{
    public class AddEndorsementBase : ComponentBase
    {
        [Inject] HttpClient Http { get; set; }
        [Inject] IService Service { get; set; }
        [Inject] IJSRuntime js { get; set; }
        [Inject] public NavigationManager navigationManager { get; set; }
        [Parameter] public int InsuranceID { get; set; }
        protected EndorsementModel Endorsement { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Endorsement = new EndorsementModel();
            Endorsement.FirstPayment = new FirstPaymentModel();
            Endorsement.Insurance = await Http
                .GetJsonAsync<InsuranceModel>($"api/insurance/GetByDetails/{InsuranceID}");
        }

        protected async void Create()
        {
            /*wait Http.SendJsonAsync(HttpMethod.Post, "api/Endorsement", Endorsement);*/

            var httpResponse = await Service.POST("api/Endorsement", Endorsement);
            if (httpResponse.Error)
            {
                await js.Message("Error", "No se ha podido realizar el registro", "error");  
            }
            else
            {
                await js.Message("Exito", "El registro se ha guardado de forma exitosa", "success");
                navigationManager.NavigateTo($"Overview/{InsuranceID}");
            }
        }
    }
}
