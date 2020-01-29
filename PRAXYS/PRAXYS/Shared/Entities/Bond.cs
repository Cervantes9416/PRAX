using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PRAXYS.Shared.Entities
{
    public class Bond
    {
        public int ID { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }
        public int UserEditedID { get; set; }
        [Required]
        public DateTime DateEdited { get; set; }
        
        [Required]
        public int CompanyID { get; set; }
        [Required]
        public int SubAgentID { get; set; }
        [Required]
        public int ClientID { get; set; }
        [Required]
        public int BeneficiaryID { get; set; }

        [Required]
        public int RiskTypeID { get; set; }
        [Required]
        public int MovementID { get; set; }
        [Required]
        public int BranchID { get; set; }
        [Required]
        public int OfficeID { get; set; }
        [Required]
        public int StatusID { get; set; }
        [Required]
        public int AgentID { get; set; }

        public string Branch { get; set; }
        [Required]
        public string BondNumber { get; set; }
        [Required]
        public string BillingNumber { get; set; }
        [Required]
        public DateTime IssueDate { get; set; }
        [Required]
        public DateTime Start { get; set; }
        [Required]
        public DateTime End { get; set; }
        public decimal CovergeAmount { get; set; }
        [Required]
        public decimal Premium { get; set; }
        [Required]
        public decimal Fee { get; set; }
        [Required]
        public decimal IssueCost { get; set; }
        [Required]
        public decimal BureauCost { get; set; }
        [Required]
        public decimal TaxPercentage { get; set; }
        [Required]
        public decimal Tax { get; set; }
        [Required]
        public decimal PremiumTotal { get; set; }
        public bool Payed { get; set; }

        [Required]
        public decimal CommissionPercentage { get; set; }
        [Required]
        public decimal GroupCommissionPercentage { get; set; }

        public Company Company { get; set; }
        public SubAgent SubAgent { get; set; }
        public Clients Client { get; set; }
        public Agent Agent { get; set; }
        public List<BondPayment> BondPayments { get; set; }
        
    }
}
