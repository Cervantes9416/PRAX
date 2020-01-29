using BlazorStrap;
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
    public class ListPaymentTypeBase : ComponentBase
    {
        [Inject] HttpClient Http { get; set; }
        [Inject] IJSRuntime js { get; set; }
        protected List<PaymentTypeModel> PaymentTypes { get; set; }
        public BSModal Modal { get; set; }

        protected async override Task OnInitializedAsync()
        {
            PaymentTypes = await Http.GetJsonAsync<List<PaymentTypeModel>>("api/Basics/GetAllPaymentTypes");
        }

        public async Task UpdateList()
        {
            PaymentTypes = await Http.GetJsonAsync<List<PaymentTypeModel>>("api/Basics/GetAllPaymentTypes");
            StateHasChanged();
        }

        public async Task Delete(int id)
        {
            var result = await js.ConfirmMessage("Antes de continuar", "Esta seguro de querer eliminar el registro");
            if (result)
            {
                await Http.DeleteAsync($"api/basics/DeletePaymentType/{id}");
                await UpdateList();
                await js.Message("Exito", "Se ha Eliminado el registro", "success");
            }
        }
    }
}
