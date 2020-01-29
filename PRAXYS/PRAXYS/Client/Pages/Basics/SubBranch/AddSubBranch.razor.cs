using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using PRAXYS.Client.Helpers;
using PRAXYS.Client.Pages.Basics.Branch;
using PRAXYS.Client.Services;
using PRAXYS.Commons.Entities.Branch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PRAXYS.Client.Pages.Basics.SubBranch
{
    public class AddSubBranchBase : ComponentBase
    {
        [Inject] HttpClient Http { get; set; }
        [Inject] IJSRuntime js { get; set; }
        [Inject] IService Service { get; set; }
        [CascadingParameter] public ListBranch ParentContent { get; set; }
        protected SubBranchModel SubBranch { get; set; }
        
        protected override void OnInitialized()
        {
            SubBranch = new SubBranchModel();
        }

        protected async Task Create()
        {
            var httpResponse = await Service.POST("api/Basics/PostSubBranch", SubBranch);
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
                    SubBranch = null;
                    await ParentContent.UpdateList();
                }*/
            }
        }

    }
}
