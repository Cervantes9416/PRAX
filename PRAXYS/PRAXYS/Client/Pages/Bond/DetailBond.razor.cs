using BlazorStrap;
using Microsoft.AspNetCore.Components;
using PRAXYS.Commons.Entities.Bond;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PRAXYS.Client.Pages.Bond
{
    public class DetailBondBase : ComponentBase
    {
        [Inject] HttpClient Http { get; set; }
        [Parameter] public int BondID { get; set; }
        protected BSModal Modal { get; set; }
        protected BondModel Bond { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Bond = await Http.GetJsonAsync<BondModel>($"api/bonds/GetWithDetails/{BondID}");
        }

        protected async void UploadData()
        {
            Bond = await Http.GetJsonAsync<BondModel>($"api/bonds/GetWithDetails/{BondID}");
        }
    }
}
