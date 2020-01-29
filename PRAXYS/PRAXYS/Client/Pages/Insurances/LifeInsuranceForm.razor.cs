using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using PRAXYS.Client.Helpers;
using PRAXYS.Commons.Entities.Insurance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRAXYS.Client.Pages.Insurances
{
    public class LifeInsuranceFormBase : ComponentBase
    {
        [Parameter] public InsuranceModel insurance { get; set; }
        [Inject] IJSRuntime js { get; set; }
        [Parameter] public bool ReadOnly { get; set; }

        protected async override Task OnAfterRenderAsync(bool firstRender)
        {
            if (ReadOnly)
            {
                await js.AddAttribute("readonly");
            }
        }
    }
}
