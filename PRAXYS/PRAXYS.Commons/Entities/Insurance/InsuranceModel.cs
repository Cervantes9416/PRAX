using PRAXYS.Commons.Entities.Address;
using PRAXYS.Commons.Entities.Agent;
using PRAXYS.Commons.Entities.Branch;
using PRAXYS.Commons.Entities.Client;
using PRAXYS.Commons.Entities.Company;
using PRAXYS.Commons.Entities.CoveragePlan;
using PRAXYS.Commons.Entities.Endorsement;
using PRAXYS.Commons.Entities.PaymentType;
using PRAXYS.Commons.Entities.SubAgent;
using PRAXYS.Commons.Enum;
using PRAXYS.Commons.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PRAXYS.Commons.Entities.Insurance
{
    public class InsuranceModel : 
        ICoveragePlanContainer, 
        ISelectPaymentType, 
        ISelectClient, 
        ISelectAgent, 
        ISelectCompany, 
        ISelectSubAgent, 
        ISelectSubBranch
    {
        public int ID { get; set; }
        
        [Required(ErrorMessage = "Campo Requerido")]
        public DateTime? ValidFrom { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        public DateTime? ValidThrought { get; set; }
        public DateTime? SeniorityDate { get; set; }
        public decimal Renewal { get; set; }
        
        [Required(ErrorMessage = "Campo Requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "Campo Requerido")]
        public int ClientID { get; set; }
        
        [Required(ErrorMessage = "Campo Requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "Campo Requerido")]
        public int AgentID { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "Campo Requerido")]
        public int SubAgentID { get; set; }
        
        [Range(1, int.MaxValue, ErrorMessage = "Campo Requerido")]
        [Required(ErrorMessage = "Campo Requerido")]
        public int CompanyID { get; set; }
        public int AddressID { get; set; }

        public bool Payed { get; set; }
        public string CurrencyType { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        public string InsuranceNumber { get; set; }
        public string InsuranceType { get; set; }

        public string PreviousInsurance { get; set; }
        public string RenewedInsurance { get; set; }

        //DATOS PRIMA
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
        public decimal ExchangeRate { get; set; }
        public InsuranceStatus Status { get; set; }

        public AgentModel Agent { get; set; }
        public CompanyModel Company { get; set; }
        public AddressModel Address { get; set; }

        //CONTACTO
        public string ReferenceName { get; set; }
        public string ReferenceNumber { get; set; }
        public string ReferenceEmail { get; set; }

        //ENDOSO
        public bool Endorsement { get; set; }
        public int EndorsementNumber { get; set; }

        public ClientModel Client { get; set; }
        public int CoveragePlanID { get; set; }
        public SubAgentModel SubAgent { get; set; }
        
        public CoveragePlanModel CoveragePlan { get; set; }
        public List<InsuranceDocumentationModel> InsuranceDocumentation { get; set; }
        public List<EndorsementModel> Endorsements { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "Campo Requerido")]
        public int PaymentTypeID { get; set; }
        public PaymentTypeModel PaymentType { get; set; }
        
        [Required(ErrorMessage = "Campo Requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "Campo Requerido")]
        public int SubBranchID { get; set; }
        public SubBranchModel SubBranch { get; set; }

        //VEHICULOS
        
        public string Brand { get; set; }
        
        public string Car_Plates { get; set; }
        
        public string Car_Use { get; set; }
        
        public int Capacity { get; set; }
        
        public string Car_Motor { get; set; }
        
        public string Model { get; set; }
       
        public string Transmission { get; set; }
        
        public string Car_Description { get; set; }


        //ACCIDENTE INSURANCE DATOS DEL ASEGURADO TITULAR
        
        public string Insuree_LastName { get; set; }
      
        public string Insuree_SecondLastName { get; set; }
       
        public string Insuree_Name { get; set; }
        public DateTime Insuree_BirthDate { get; set; }
        
        public string Insuree_RFC { get; set; }
        
        public string Insuree_CURP { get; set; }
        
        public string Insuree_Gender { get; set; }

        //ASEGURADO SECUNDARIO
        
        public string Secondary_Insuree_LastName { get; set; }
       
        public string Secondary_Insuree_SecondLastName { get; set; }
       
        public string Secondary_Insuree_Name { get; set; }
        public DateTime Secondary_Insuree_BirthDate { get; set; }
      
        public string Secondary_Insuree_RFC { get; set; }
       
        public string Secondary_Insuree_CURP { get; set; }
       
        public string Secondary_Insuree_Gender { get; set; }

        //COMISION
        public decimal Comission_NetPremium { get; set; }
        public decimal Comission_NetPremium_Percentage { get; set; }
        public decimal Comission_Surcharges { get; set; }
        public decimal Comission_Surcharges_Percentage { get; set; }
        public decimal Comission_Rights { get; set; }
        public decimal Comission_Rights_Percentage { get; set; }
        public decimal Comission_Special { get; set; }
        public decimal Comission_Special_Percentage { get; set; }


        public string getStatus()
        {
            var txt = "";
            switch (this.Status)
            {
                case InsuranceStatus.Valid:
                    txt = "far fa-check-circle text-success";
                    break;
                case InsuranceStatus.Defeated:
                    txt = "fas fa-ban text-warning";
                    break;
                case InsuranceStatus.Cancelled:
                    txt = "far fa-times-circle text-danger";
                    break;
                default:
                    break;
            }

            return txt;
        }
    }
}
