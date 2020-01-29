using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using PRAXYS.Client.Helpers;
using PRAXYS.Commons.Entities.Bond;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PRAXYS.Client.Pages.Bond
{
    public class BondListBase : ComponentBase
    {
        [Inject] HttpClient Http { get; set; }
        [Inject] IJSRuntime js { get; set; }
        protected List<BondListModel> Bonds { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Bonds = await Http.GetJsonAsync<List<BondListModel>>("api/bonds");
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await js.DataTableInit();
        }
    }
}
