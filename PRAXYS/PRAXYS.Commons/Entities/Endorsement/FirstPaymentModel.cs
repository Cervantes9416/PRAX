using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PRAXYS.Commons.Entities.Endorsement
{
    public class FirstPaymentModel
    {
        //DETALLES DE PRIMAS
        [Required(ErrorMessage = "Campo Requerido")]
        public decimal Premium { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        public decimal NetPremium { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        public decimal Discount { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        public decimal Surcharges { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        public decimal Rights { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        public decimal tax { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        public decimal SubTotal { get; set; }
        public decimal TotalPremium { get; set; }
    }
}
