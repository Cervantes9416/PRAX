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
        //[Required(ErrorMessage = "Campo Requerido")]
        public decimal Premium { get; set; }
        //[Required(ErrorMessage = "Campo Requerido")]
        public decimal NetPremium { get; set; }
        //[Required(ErrorMessage = "Campo Requerido")]
        public decimal Discount { get; set; }
        //[Required(ErrorMessage = "Campo Requerido")]
        public decimal DiscountPercentage { get; set; }
        //[Required(ErrorMessage = "Campo Requerido")]
        public decimal Surcharges { get; set; }
        //[Required(ErrorMessage = "Campo Requerido")]
        public decimal Rights { get; set; }
        //[Required(ErrorMessage = "Campo Requerido")]
        public decimal tax { get; set; }
        //[Required(ErrorMessage = "Campo Requerido")]
        public decimal TaxPercentage { get; set; }
        //[Required(ErrorMessage = "Campo Requerido")]
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
