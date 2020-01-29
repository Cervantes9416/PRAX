using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
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
        [Inject] HttpClient Http { get; set; }
        [Inject] IJSRuntime js { get; set; }
        [Parameter] public int InsuranceID { get; set; }
        protected InsuranceModel Insurance { get; set; }
        protected EndorsementModel Endorsement { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Insurance = await Http
                .GetJsonAsync<InsuranceModel>($"api/Insurance/GetByDetails/{InsuranceID}");
            Endorsement = new EndorsementModel();
        }
    }
}
