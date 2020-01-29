using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using PRAXYS.Client.Helpers;
using PRAXYS.Commons.Entities.Endorsement;
using PRAXYS.Commons.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PRAXYS.Client.Shared.SelectInput
{
    public class SelectEndorsementBase : ComponentBase
    {
        [Inject] HttpClient Http { get; set; }
        [Inject] IJSRuntime js { get; set; }
        [Parameter] public ISelectEndorsementType SelectEndorsementType { get; set; }
        protected List<EndorsementTypeModel> Endorsements { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Endorsements = await Http.GetJsonAsync<List<EndorsementTypeModel>>("api/Endorsement/GetAllEndorsementType");
        }

        protected async override Task OnAfterRenderAsync(bool firstRender)
        {
            await js.Select2Init();
        }
    }
}
