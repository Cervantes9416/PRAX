using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using PRAXYS.Client.Helpers;
using PRAXYS.Client.Pages.Insurances;
using PRAXYS.Commons.Entities.Branch;
using PRAXYS.Commons.Interfaces;
using PRAXYS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PRAXYS.Client.Shared.SelectInput
{
    public class SelectSubBranchBase : ComponentBase
    {
        [Inject] HttpClient Http { get; set; }
        [Inject] IJSRuntime js { get; set; }
        [CascadingParameter] InsuranceForm InsuranceForm { get; set; }
        [Parameter] public EventCallback<string> InputFormMethod { get; set; }
        protected string InputType { get; set; }
        protected int _branchID { get; set; }
        [Parameter] public int BranchID { get { return _branchID;  }
            set
            {
                if (value != BranchID)
                {
                    _branchID = value;
                    ChangeList();
                }
            } 
        }

        [Parameter] public ISelectSubBranch SelectSubBranch { get; set; }
        protected int _subBranchID
        {
            get 
            {
                return SelectSubBranch.SubBranchID; 
            }
            set
            {
                SelectSubBranch.SubBranchID = value;
                ReturnInputForm();
            }
        }

        protected List<SubBranchModel> SubBranchList { get; set; }

        protected async override Task OnInitializedAsync()
        {
            if (BranchID != 0)
            {
                SubBranchList = await Http.GetJsonAsync<List<SubBranchModel>>($"api/branch/GetAllSubBranchWithBranchID/{BranchID}");
            }
            else
            {
                SubBranchList = await Http.GetJsonAsync<List<SubBranchModel>>("api/branch/GetAllSubBranch");
            }
        }

        private async void ChangeList()
        {
            SubBranchList = null;
            _subBranchID = 0;
            StateHasChanged();
            SubBranchList = await Http.GetJsonAsync<List<SubBranchModel>>($"api/branch/GetAllSubBranchWithBranchID/{_branchID}");
            StateHasChanged();
        }

        private async void ReturnInputForm()
        {
            if (_subBranchID != 0)
            {
                var subBranch = await Http.GetJsonAsync<SubBranchModel>($"api/branch/GetSubBranch/{_subBranchID}");
                await InputFormMethod.InvokeAsync(subBranch.InputForm);
            }
        }

        protected async override Task OnAfterRenderAsync(bool firstRender)
        {
            await js.Select2Init();
        }
    }
}
