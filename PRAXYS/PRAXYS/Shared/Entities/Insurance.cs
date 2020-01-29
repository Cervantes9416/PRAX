using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PRAXYS.Shared.Entities
{
    public class Insurance
    {
        public int ID { get; set; }
        [Required]
        [MaxLength(50)]
        public string InsuranceNumber { get; set; }
        [Required]
        public DateTime? ValidFrom { get; set; }
        [Required]
        public DateTime? ValidThrought { get; set; }
        public DateTime? SeniorityDate { get; set; }
        public decimal? Renewal { get; set; }
        [Required]
        public int ClientID { get; set; }
        [Required]
        public int AgentID { get; set; }
        [Required]
        public int SubBranchID { get; set; }
        [Required]
        public int CompanyID { get; set; }
        [Required]
        public int SubAgentID { get; set; }
        [Required]
        public int PaymentTypeID { get; set; }
        [Required]
        public int Status { get; set; }
        public bool Payed { get; set; }
        [MaxLength(50)]
        public string CurrencyType { get; set; }

        //DATOS PRIMA
        [Required]
        public decimal NetPremium { get; set; }
        [Required]
        public decimal Discount { get; set; }
        [Required]
        public decimal DiscountPercentage { get; set; }
        [Required]
        public decimal Surcharges { get; set; }
        [Required]
        public decimal Rights { get; set; }
        [Required]
        public decimal tax { get; set; }
        [Required]
        public decimal TaxPercentage { get; set; }
        [Required]
        public decimal SubTotal { get; set; }
        [Required]
        public decimal TotalPremium { get; set; }
        [Required]
        public decimal ExchangeRate { get; set; }

        public string PreviousInsurance { get; set; }
        public string RenewedInsurance { get; set; }

        //ENDOSO
        public bool Endorsement { get; set; }
        public int EndorsementNumber { get; set; }

        public SubBranch SubBranch { get; set; }
        public Clients Client { get; set; }
        public Company Company { get; set; }
        public Agent Agent { get; set; }
        public SubAgent SubAgent { get; set; }
        public PaymentType PaymentType { get; set; }
        public List<InsuranceDocumentation> InsuranceDocumentation { get; set; }
        public List<PaymentInformation> Payments { get; set; }
        public List<Endorsement> Endorsements { get; set; }

        //CONTACTO
        public string ReferenceName { get; set; }
        public string ReferenceNumber { get; set; }
        public string ReferenceEmail { get; set; }

        //VEHICULOS
        [MaxLength(30)]
        public string Brand { get; set; }
        [MaxLength(30)]
        public string Car_Plates { get; set; }
        [MaxLength(30)]
        public string Car_Use { get; set; }
        [MaxLength(30)]
        public int Capacity { get; set; }
        [MaxLength(30)]
        public string Car_Motor { get; set; }
        [MaxLength(30)]
        public string Model { get; set; }
        [MaxLength(30)]
        public string Transmission { get; set; }
        [MaxLength(150)]
        public string Car_Description { get; set; }


        //ACCIDENTE INSURANCE DATOS DEL ASEGURADO TITULAR
        [MaxLength(30)]
        public string Insuree_LastName { get; set; }
        [MaxLength(30)]
        public string Insuree_SecondLastName { get; set; }
        [MaxLength(50)]
        public string Insuree_Name { get; set; }
        public DateTime Insuree_BirthDate { get; set; }
        [MaxLength(20)]
        public string Insuree_RFC { get; set; }
        [MaxLength(20)]
        public string Insuree_CURP { get; set; }
        [MaxLength(20)]
        public string Insuree_Gender { get; set; }

        //ASEGURADO SECUNDARIO
        [MaxLength(30)]
        public string Secondary_Insuree_LastName { get; set; }
        [MaxLength(30)]
        public string Secondary_Insuree_SecondLastName { get; set; }
        [MaxLength(50)]
        public string Secondary_Insuree_Name { get; set; }
        public DateTime Secondary_Insuree_BirthDate { get; set; }
        [MaxLength(20)]
        public string Secondary_Insuree_RFC { get; set; }
        [MaxLength(20)]
        public string Secondary_Insuree_CURP { get; set; }
        [MaxLength(20)]
        public string Secondary_Insuree_Gender { get; set; }

        //COMISION
        [Required]
        public decimal Comission_NetPremium { get; set; }
        [Required]
        public decimal Comission_NetPremium_Percentage { get; set; }
        [Required]
        public decimal Comission_Surcharges { get; set; }
        [Required]
        public decimal Comission_Surcharges_Percentage { get; set; }
        [Required]
        public decimal Comission_Rights { get; set; }
        [Required]
        public decimal Comission_Rights_Percentage { get; set; }
        [Required]
        public decimal Comission_Special { get; set; }
        [Required]
        public decimal Comission_Special_Percentage { get; set; }
    }
}
