using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using PRAXYS.Commons.Entities.Bond;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRAXYS.Client.Pages.Bond
{
    public class BondFormBase : ComponentBase
    {
        [Parameter] public BondModel Bond { get; set; }
        [Parameter] public EventCallback OnValidSubmit { get; set; }
        [Inject] IJSRuntime js { get; set; }

        protected async override Task OnAfterRenderAsync(bool firstRender)
        {
            await js.InvokeVoidAsync("initDatePicker");
        }
    }
}
