using PRAXYS.Commons.Entities.Client;
using PRAXYS.Commons.Entities.Company;
using PRAXYS.Commons.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace PRAXYS.Commons.Entities.Insurance
{
    public class InsuranceListModel
    {
        public int ID { get; set; }
        public string InsuranceNumber { get; set; }
        public DateTime? ValidThrought { get; set; }
        public string PersonType { get; set; }
        public int CompanyID { get; set; }
        public bool Payed { get; set; }
        
        public string InsuranceType { get; set; }
        public InsuranceStatus Status { get; set; }

        public ClientMinModel Client { get; set; }
        public CompanyMinModel Company { get; set; }

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
