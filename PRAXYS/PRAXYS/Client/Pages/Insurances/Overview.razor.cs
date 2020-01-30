using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using PRAXYS.Commons.Entities.Insurance;
using PRAXYS.Client.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using PRAXYS.Client.Services;

namespace PRAXYS.Client.Pages.Insurances
{
    public class OverviewBase : ComponentBase
    {
        [Inject] HttpClient Http { get; set; }
        [Inject] IJSRuntime js { get; set; }
        [Inject] IService Service { get; set; }
        [Parameter] public int InsuranceID { get; set; }
        protected List<InsuranceEndorsementModel> InsuranceList { get; set; }
        protected RenderFragment ModalContent { get; set; }
        protected InsuranceModel Insurance { get; set; }
        protected InsuranceDocumentationModel InsuranceDocumentation { get; set; } = new InsuranceDocumentationModel();

        protected decimal Total { get; set; }
        protected decimal TotalReturn { get; set; }
        protected decimal Balance { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Insurance = await Http
                .GetJsonAsync<InsuranceModel>($"api/insurance/{InsuranceID}");

            InsuranceList = await Http
                .GetJsonAsync<List<InsuranceEndorsementModel>>($"api/insurance/GetAllByInsuranceNumber/{Insurance.InsuranceNumber}");

            Total = InsuranceList
                .Where(x => x.EndorsementType == "Aumento")
                .Sum(x => x.TotalPremium) + InsuranceList[0].TotalPremium;

            TotalReturn = InsuranceList
                .Where(x => x.EndorsementType == "Disminucion").Sum(x => x.TotalPremium);

            Balance = Total - TotalReturn;
        }

        protected async void UploadFile()
        {
            InsuranceDocumentation.InsuranceID = InsuranceID;
            await Http.SendJsonAsync(HttpMethod.Post, "api/InsuranceDocumentation", InsuranceDocumentation);
            Insurance.InsuranceDocumentation = await Http.GetJsonAsync<List<InsuranceDocumentationModel>>($"api/InsuranceDocumentation/GetAllByID/{InsuranceID}");
            StateHasChanged();
        }

        protected async void DeleteFile(int id)
        {
            var result = await Http.DeleteAsync($"api/InsuranceDocumentation/{id}");
            Insurance.InsuranceDocumentation = await Http.GetJsonAsync<List<InsuranceDocumentationModel>>($"api/InsuranceDocumentation/GetAllByID/{InsuranceID}");
        }

        protected async void DeleteEndorsement(int id)
        {
            var result = await Http.DeleteAsync($"api/Insurance/{id}");
            if (result.IsSuccessStatusCode)
            {
                await js.Message("Exito", "El registro se ha eliminado de forma exitosa", "success");
                /*InsuranceList = await Http
                    .GetJsonAsync<List<InsuranceEndorsementModel>>($"api/insurance/GetAllByInsuranceNumber/{Insurance.InsuranceNumber}");
                ModalContent = null;
                StateHasChanged();*/
                await js.Reload();
            }
            else
            {
                await js.Message("Error", "No se ha podido eliminar el registro", "error");
            }
        }

        protected async void CancelAll()
        {
            var result = await js.ConfirmMessage("Antes de continuar", "Esta seguro de querer cancelar esta poliza");
            if (result)
            {
                var httpResponse = await Service.POST("api/Insurance/CancelInsurance", Insurance);
                if (httpResponse.Error)
                {
                    await js.Message("Error", "No se ha podido realizar el registro", "error");
                }
                else
                {
                    await js.Message("Exito", "El documento ha sido cancelado", "success");
                    await js.Reload();
                }
            }
        }

        protected string textColor(string EndorsementType)
        {
            switch (EndorsementType)
            {
                case "Aumento":
                    return "text-success";
                case "Disminucion":
                    return "text-danger";
                default:
                    return "";
            }
        }
    } 
}
