using PRAXYS.Commons.Entities.Agent;
using PRAXYS.Commons.Entities.BondPayment;
using PRAXYS.Commons.Entities.Client;
using PRAXYS.Commons.Entities.Company;
using PRAXYS.Commons.Entities.PaymentType;
using PRAXYS.Commons.Entities.SubAgent;
using PRAXYS.Commons.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PRAXYS.Commons.Entities.Bond
{
    public class BondModel : ISelectClient, ISelectCompany, ISelectAgent, ISelectSubAgent
    {
        public int ID { get; set; }
        public DateTime DateCreated { get; set; }
        public int UserEditedID { get; set; }
        public DateTime DateEdited { get; set; }

        [Required]
        public int CompanyID { get; set; }
        [Required]
        public int OfficeID { get; set; }
        [Required]
        public int SubAgentID { get; set; }
        [Required]
        public int BranchID { get; set; }
        
        [Required]
        public int RiskTypeID { get; set; }
        [Required]
        public int MovementID { get; set; }
        public int StatusID { get; set; }

        public string Branch { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        public string BondNumber { get; set; }
        public string BillingNumber { get; set; }
        public DateTime IssueDate { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        public DateTime? Start { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        public DateTime? End { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        public decimal CovergeAmount { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        public decimal Premium { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        public decimal Fee { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        public decimal IssueCost { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        public decimal BureauCost { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        public decimal TaxPercentage { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        public decimal Tax { get; set; }
        public decimal PremiumTotal { get; set; }
        public bool Payed { get; set; }

        public decimal CommissionPercentage { get; set; }
        public decimal GroupCommissionPercentage { get; set; }

        public int ClientID { get; set; }
        public ClientModel Client { get; set; }
        public CompanyModel Company { get; set; }
        public int AgentID { get; set; }
        public AgentModel Agent { get; set; }
        public SubAgentModel SubAgent { get; set; }
        public List<BondPaymentModel> BondPayments { get; set; }

        //BENEFICIARIO
        public string Beneficiary { get; set; }

    }
}
