using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using PRAXYS.Client.Helpers;
using PRAXYS.Client.Services;
using PRAXYS.Commons.Entities.Endorsement;
using PRAXYS.Commons.Entities.Insurance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PRAXYS.Client.Pages.Endorsement
{
    public class ModificationEndorsementBase : ComponentBase
    {
        [Inject] protected HttpClient Http { get; set; }
        [Inject] protected IJSRuntime js { get; set; }
        [Inject] protected IService Service { get; set; }
        [Inject] protected NavigationManager NavigationManager { get; set; }
        [Parameter] public int InsuranceID { get; set; }
        protected InsuranceModel Insurance { get; set; }
        protected EndorsementModel Endorsement { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Insurance = await Http
                .GetJsonAsync<InsuranceModel>($"api/Insurance/GetByDetails/{InsuranceID}");
            Endorsement = new EndorsementModel();
            Endorsement.Insurance = Insurance;
        }

        protected virtual async Task CreateEndorsement()
        {
            var httpResponse = await Service.POST("api/Endorsement/CreateEndorsementModification", 
                new ModificationEndorsementRequest() 
                { 
                    Endorsement = Endorsement, 
                    Insurance = Insurance 
                });
            if (httpResponse.Error)
            {
                await js.Message("Error", "No se ha podido realizar el registro", "error");
            }
            else
            {
                await js.Message("Exito", "Se ha realizado el registro", "success");
                NavigationManager.NavigateTo($"Overview/{InsuranceID}");
            }
        }
    }
}
