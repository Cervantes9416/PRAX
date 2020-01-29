using PRAXYS.Commons.Entities.Insurance;
using PRAXYS.Commons.Entities.PaymentType;
using PRAXYS.Commons.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PRAXYS.Commons.Entities.Endorsement
{
    public class EndorsementModel : ISelectPaymentType, ISelectEndorsementType
    {
        public int ID { get; set; }
        public int InsuranceID { get; set; }
        
        [Required(ErrorMessage = "Campo Obligatorio")]
        public DateTime? ValidFrom { get; set; }
        
        [Required(ErrorMessage = "Campo Obligatorio")]
        public DateTime? ValidThrought { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public string Description { get; set; }
        public string Notes { get; set; }

        //DETALLES DE PRIMAS
       
        public decimal Premium { get; set; }
        public decimal NetPremium { get; set; }
        public decimal Discount { get; set; }
        public decimal DiscountPercentage { get; set; }
        public decimal Surcharges { get; set; }
        public decimal SurchargesPercentage { get; set; }
        public decimal Rights { get; set; }
        public decimal tax { get; set; }
        public decimal TaxPercentage { get; set; }
        public decimal SubTotal { get; set; }
        public decimal TotalPremium { get; set; }

        //COMISION
        public decimal Comission_NetPremium { get; set; }
        public decimal Comission_NetPremium_Percentage { get; set; }
        public decimal Comission_Surcharges { get; set; }
        public decimal Comission_Surcharges_Percentage { get; set; }
        public decimal Comission_Rights { get; set; }
        public decimal Comission_Rights_Percentage { get; set; }
        public decimal Comission_Special { get; set; }
        public decimal Comission_Special_Percentage { get; set; }

        public InsuranceModel Insurance { get; set; }
        public EndorsementTypeModel EndorsementType { get; set; }
        public FirstPaymentModel FirstPayment { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Campo Requerido")]
        [Required(ErrorMessage = "Campo Obligatorio")]
        public int PaymentTypeID { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Campo Requerido")]
        [Required(ErrorMessage = "Campo Obligatorio")]
        public int EndorsementTypeID { get; set; }
        
        public PaymentTypeModel PaymentType { get; set; }
    }
}
