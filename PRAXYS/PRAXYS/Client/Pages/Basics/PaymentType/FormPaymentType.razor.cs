using Microsoft.AspNetCore.Components;
using PRAXYS.Commons.Entities.PaymentType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRAXYS.Client.Pages.Basics.PaymentType
{
    public class FormPaymentTypeBase : ComponentBase
    {
        [Parameter] public EventCallback OnValidSubmit { get; set; }
        [Parameter] public PaymentTypeModel PaymentType { get; set; }


        protected async override Task OnInitializedAsync()
        {

        }
    }
}
