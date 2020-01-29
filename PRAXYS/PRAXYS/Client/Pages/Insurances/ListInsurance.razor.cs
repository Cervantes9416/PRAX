  using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using PRAXYS.Client.Helpers;
using PRAXYS.Commons.Entities.Insurance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PRAXYS.Client.Pages.Insurances
{
    public class ListInsuranceBase : ComponentBase
    {
        
        [Parameter] public List<InsuranceListModel> Insurances { get; set; }
        [Inject] IJSRuntime js { get; set; }

        protected override async Task OnInitializedAsync()
        {
           
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await js.InvokeAsync<bool>("AlertTest");
            await js.DataTableInit();
        }
    }
}
