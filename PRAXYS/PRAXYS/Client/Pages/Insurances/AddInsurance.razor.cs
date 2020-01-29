using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using PRAXYS.Commons.Entities.Insurance;
using PRAXYS.Client.Helpers;
using PRAXYS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using PRAXYS.Client.Services;

namespace PRAXYS.Client.Pages.Insurances
{
    public class AddInsuranceBase : ComponentBase
    {
        [Inject] HttpClient http { get; set; }
        [Inject] IJSRuntime js { get; set; }
        [Inject] IService Service { get; set; }
        [Inject] NavigationManager NavigationManager { get; set; }
        [Parameter] public int BranchID { get; set; } = 3;
        protected InsuranceModel Insurance;
        
        private int _branchInsurance { get; set; }
        protected int BranchInsurance 
        { 
            get 
            { 
                return _branchInsurance; 
            }
            set 
            {
                NavigationManager.NavigateTo($"insurance/Create/{value}");
                _branchInsurance = value;
            }
        }

        protected override void OnInitialized()
        {
            Insurance = new InsuranceModel();
            Insurance.SeniorityDate = DateTime.Now;
        }

        protected async void Create()
        {
            //await http.SendJsonAsync(HttpMethod.Post, "api/insurance", Insurance);
            var httpResponse = await Service.POST("api/insurance/Create", Insurance);
            if (httpResponse.Error)
            {
                await js.Message("Error", "No se ha podido realizar el registro", "error");
            }
            else
            {
                await js.Message("Exito", "El registro se ha creado de forma exitosa", "success");
                NavigationManager.NavigateTo("insurance/list");
            }
        }

        protected string GetTItle()
        {
            switch (BranchID)
            {
                case 1:
                    return "Accidentes y Enfermedades";
                case 2:
                    return "Daños";
                case 3:
                    return "Vehiculos";
                case 4:
                    return "Vida";
                default:
                    return "";
            }
        }
    }
}
