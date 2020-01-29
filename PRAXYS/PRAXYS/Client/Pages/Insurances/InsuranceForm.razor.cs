using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using PRAXYS.Client.Helpers;
using PRAXYS.Commons.Entities;
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
                Insurance.Discount = Insurance.NetPremium * (value / 100);
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
                Insurance.Surcharges = Insurance.SubTotal * (value / 100);
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
                Insurance.tax = Insurance.SubTotal * (value / 100);
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
            }
        }

        public decimal CommissionNet { get; set; }

        protected decimal _commissionNet
        {
            get
            {
                return Insurance.Comission_NetPremium;
            }
            set
            {
                Insurance.Comission_NetPremium_Percentage = value;
                Insurance.Comission_NetPremium = Insurance.NetPremium * (value/100);
            }
        }

        protected async void OnValidCreate()
        {
            await OnValidSubmit.InvokeAsync(null);
        }


        protected void TotalPremium()
        {
            Insurance.SubTotal = Insurance.NetPremium - Insurance.Discount + Insurance.Surcharges + Insurance.Rights;
            Insurance.TotalPremium = Insurance.NetPremium - Insurance.Discount + Insurance.Surcharges + Insurance.Rights + Insurance.tax;
        }

        

    }
}
