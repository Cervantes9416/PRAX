using PRAXYS.Commons.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace PRAXYS.Commons.Entities.Insurance
{
    public class InsuranceEndorsementModel
    {
        public int ID { get; set; }
        public string InsuranceNumber { get; set; }
        public DateTime? ValidThrought { get; set; }

        public InsuranceStatus Status { get; set; }
        public string EndorsementType { get; set; }
        public string Description { get; set; }
        public int EndorsementNumber { get; set; }
        public bool Payed { get; set; }
        public decimal TotalPremium { get; set; }
        public decimal NetPremium { get; set; }

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
