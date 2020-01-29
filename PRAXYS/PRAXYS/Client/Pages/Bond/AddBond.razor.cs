using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using PRAXYS.Client.Services;
using PRAXYS.Commons.Entities.Bond;
using PRAXYS.Client.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PRAXYS.Client.Pages.Bond
{
    public class AddBondBase : ComponentBase
    {
        [Inject] HttpClient Http { get; set; }
        [Inject] IService Service { get; set; }
        [Inject] IJSRuntime js { get; set; }
        [Inject] NavigationManager navigationManager { get; set; }
        protected BondModel Bond { get; set; }

        protected override void OnInitialized()
        {
            Bond = new BondModel();
        }

        protected async void Create()
        {
            var httpResponse = await Service.POST("api/bonds/Create", Bond);
            if (httpResponse.Error)
            {
                await js.Message("Error", "No se ha podido realizar el registro", "error");
            }
            else
            {
                await js.Message("Exito", "El registro se ha creado de forma exitosa", "success");
                navigationManager.NavigateTo("/bonds/list");
            }
        }
    }
}
