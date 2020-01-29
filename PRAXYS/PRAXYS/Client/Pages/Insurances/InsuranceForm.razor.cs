using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using PRAXYS.Client.Helpers;
using PRAXYS.Commons.Entities;
using PRAXYS.Commons.Entities.Address;
using PRAXYS.Commons.Entities.Agent;
using PRAXYS.Commons.Entities.Client;
using PRAXYS.Commons.Entities.Company;
using PRAXYS.Commons.Entities.CoveragePlan;
using PRAXYS.Commons.Entities.Insurance;
using PRAXYS.Commons.Entities.SubAgent;
using PRAXYS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PRAXYS.Client.Pages.Insurances
{
    public class InsuranceFormBase : ComponentBase
    {
        [Inject] HttpClient Http { get; set; }
        [Inject] IJSRuntime js { get; set; } 
        [Parameter] public InsuranceModel Insurance { get; set; }
        [Parameter] public EventCallback OnValidSubmit { get; set; }
        [Parameter] public int BranchID { get; set; }
        protected List<AddressModel> Addresses { get; set; }


        //PREMIUM 
        protected decimal _netPremium 
        { 
            get { return Insurance.NetPremium; }
            set 
            {
                Insurance.NetPremium = value;
                TotalPremium();
            }
        }

        public decimal Discount { get; set; }
        public decimal _discountPercentage
        {
            get { return Insurance.DiscountPercentage; }
            set
            {
                Insurance.DiscountPercentage = value;
                TotalPremium();
            }
        }

        public decimal Surcharges { get; set; }
        public decimal _surchargesPercentage
        {
            get { return Insurance.SurchargesPercentage; }
            set
            {
                Insurance.SurchargesPercentage = value;
                TotalPremium();
            }
        }

        public decimal _rights
        {
            get { return Insurance.Rights; }
            set
            {
                Insurance.Rights = value;
                TotalPremium();
            }
        }

        public decimal tax { get; set; }
        public decimal _taxPercentage
        {
            get { return Insurance.TaxPercentage; }
            set
            {
                Insurance.TaxPercentage = value;
                TotalPremium();
            }
        }

        public decimal SubTotal { get; set; }
        
        protected decimal _totalPremium {
            get 
            {
                return Insurance.TotalPremium;
            }
            set
            {
                Insurance.TotalPremium = value;
                TotalPremium();
            }
        }

        public decimal CommissionNet { get; set; }

        protected decimal _commissionNet
        {
            get
            {
                return Insurance.Comission_NetPremium_Percentage;
            }
            set
            {
                Insurance.Comission_NetPremium_Percentage = value;
                TotalPremium();
            }
        }

        protected async void OnValidCreate()
        {
            if (Insurance.Renewal > 0 && (Insurance.PreviousInsurance == null || Insurance.PreviousInsurance == ""))
            {
                await js.Message("Error", "Al renovar una poliza es necesario especificar el numero del documento anterior", "error");
            }
            else
            {
                await OnValidSubmit.InvokeAsync(null);
            }
            //await OnValidSubmit.InvokeAsync(null);
        }

        protected async void GetListAddress(int id)
        {
            var Client = await Http.GetJsonAsync<ClientModel>($"api/Clients/GetByDetails/{id}");
            Addresses = Client.ClientAddresses.Select(x => x.Address).ToList();

            StateHasChanged();
        }

        protected void TotalPremium()
        {
            Insurance.Discount = Insurance.NetPremium * (Insurance.DiscountPercentage / 100);
            Insurance.Surcharges = Insurance.SubTotal * (Insurance.SurchargesPercentage / 100);
            Insurance.SubTotal = Insurance.NetPremium - Insurance.Discount + Insurance.Surcharges + Insurance.Rights;
            Insurance.tax = Insurance.SubTotal * (Insurance.TaxPercentage / 100);
            Insurance.TotalPremium = Insurance.NetPremium - Insurance.Discount + Insurance.Surcharges + Insurance.Rights + Insurance.tax;
            Insurance.Comission_NetPremium = Insurance.NetPremium * (Insurance.Comission_NetPremium_Percentage / 100);

            StateHasChanged();
        }

        

    }
}
