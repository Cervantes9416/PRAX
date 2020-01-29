using Microsoft.AspNetCore.Components;
using PRAXYS.Commons.Entities.Endorsement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PRAXYS.Client.Pages.Endorsement
{
    public class EditEndorsementBase : ComponentBase
    {
        [Inject] HttpClient Http { get; set; }
        protected EndorsementModel Endorsement { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Endorsement = await Http.GetJsonAsync<EndorsementModel>("api/endorsement");
        }
    }
}
