using Microsoft.AspNetCore.Components;
using PRAXYS.Commons.Entities.PaymentType;
using PRAXYS.Commons.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PRAXYS.Client.Shared.SelectInput
{
    public class SelectPaymentTypeBase : ComponentBase
    {
        [Inject] public HttpClient Http { get; set; }
        [Parameter] public ISelectPaymentType SelectPayment { get; set; }
        protected List<PaymentTypeModel> PaymentTypes { get; set; }

        protected async override Task OnInitializedAsync()
        {
            PaymentTypes = await Http
                .GetJsonAsync<List<PaymentTypeModel>>("api/Basics/GetAllPaymentTypes");
        }

        protected override void OnParametersSet()
        {
            if (PaymentTypes != null)
            {
                SelectPayment.PaymentType = PaymentTypes
                .Where(x => x.ID == SelectPayment.PaymentTypeID)
                .FirstOrDefault();
            }
         
            StateHasChanged();
        }
    }
}
