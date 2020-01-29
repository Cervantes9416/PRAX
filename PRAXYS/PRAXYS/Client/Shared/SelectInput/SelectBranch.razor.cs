using Microsoft.AspNetCore.Components;
using PRAXYS.Commons.Entities.Branch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PRAXYS.Client.Shared.SelectInput
{
    public class SelectBranchBase : ComponentBase
    {
        [Inject] HttpClient Http { get; set; }
        protected List<BranchModel> Branches { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Branches = await Http.GetJsonAsync<List<BranchModel>>("api/branch/GetAllBranchs");
        }
    }
}
