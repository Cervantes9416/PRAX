using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using PRAXYS.Client.Helpers;
using PRAXYS.Client.Services;
using PRAXYS.Commons.Entities.Branch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PRAXYS.Client.Pages.Basics.Branch
{
    public class AddBranchBase : ComponentBase
    {
        [Inject] HttpClient Http { get; set; }
        [Inject] JSRuntime js { get; set; }
        [Inject] IService Service { get; set; }
        [CascadingParameter] public ListBranch ParentContent { get; set; }
        protected BranchModel Branch {get;set;}

        protected override void OnInitialized()
        {
            Branch = new BranchModel();
        }

        protected async Task Create()
        {
            var httpResponse = await Service.POST("api/basics/PostBranch", Branch);
            if (httpResponse.Error)
            {
                await js.Message("Error", "No se ha podido realizar el registro", "error");
            }
            else
            {
                await js.Message("Exito", "El registro se ha guardado de forma exitosa", "success");
                await js.Reload();
                /*if (ParentContent != null)
                {
                    ParentContent.Modal.Hide();
                    Branch = null;
                    await ParentContent.UpdateList();
                }*/
            }
        }
    }
}
