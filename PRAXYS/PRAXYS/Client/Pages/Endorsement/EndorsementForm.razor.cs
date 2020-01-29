using Microsoft.AspNetCore.Components;
using PRAXYS.Commons.Entities.Endorsement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRAXYS.Client.Pages.Endorsement
{
    public class EndorsementFormBase : ComponentBase
    {
        [Parameter] public EndorsementModel Endorsement { get; set; }
        [Parameter] public EventCallback OnValidSubmit { get; set; }

        protected void TotalPremium()
        {
            Endorsement.Discount = Endorsement.NetPremium * (Endorsement.DiscountPercentage / 100);
            Endorsement.Surcharges = Endorsement.SubTotal * (Endorsement.SurchargesPercentage / 100);
            Endorsement.SubTotal = Endorsement.NetPremium - Endorsement.Discount + Endorsement.Surcharges + Endorsement.Rights;
            Endorsement.tax = Endorsement.SubTotal * (Endorsement.TaxPercentage / 100);
            Endorsement.TotalPremium = Endorsement.NetPremium - Endorsement.Discount + Endorsement.Surcharges + Endorsement.Rights + Endorsement.tax;
            Endorsement.Comission_NetPremium = Endorsement.NetPremium * (Endorsement.Comission_NetPremium_Percentage / 100);

            StateHasChanged();
        }

        protected decimal _netPremium
        {
            get { return Endorsement.NetPremium; }
            set
            {
                Endorsement.NetPremium = value;
                TotalPremium();
            }
        }

        public decimal Discount { get; set; }
        public decimal _discountPercentage
        {
            get { return Endorsement.DiscountPercentage; }
            set
            {
                Endorsement.DiscountPercentage = value;
                TotalPremium();
            }
        }

        public decimal Surcharges { get; set; }
        public decimal _surchargesPercentage
        {
            get { return Endorsement.SurchargesPercentage; }
            set
            {
                Endorsement.Surcharges = value;
                TotalPremium();
            }
        }

        public decimal _rights
        {
            get { return Endorsement.Rights; }
            set
            {
                Endorsement.Rights = value;
                TotalPremium();
            }
        }

        public decimal tax { get; set; }
        public decimal _taxPercentage
        {
            get { return Endorsement.TaxPercentage; }
            set
            {
                Endorsement.TaxPercentage = value;
                TotalPremium();
            }
        }

        public decimal SubTotal { get; set; }

        protected decimal _totalPremium
        {
            get
            {
                return Endorsement.TotalPremium;
            }
            set
            {
                Endorsement.TotalPremium = value;
                TotalPremium();
            }
        }

        public decimal CommissionNet { get; set; }

        protected decimal _commissionNet
        {
            get
            {
                return Endorsement.Comission_NetPremium_Percentage;
            }
            set
            {
                Endorsement.Comission_NetPremium_Percentage = value;
                TotalPremium();
            }
        }

    }
}
