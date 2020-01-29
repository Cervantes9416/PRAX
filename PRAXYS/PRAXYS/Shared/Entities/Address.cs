using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PRAXYS.Shared.Entities
{
    public class Address
    {
        public int ID { get; set; }
        /*[MinLength(50)]
        public string Street { get; set; }
        [MinLength(50)]
        public string Colony { get; set; }*/
        [MaxLength(200)]
        public string AddressLine { get; set; }
        [MaxLength(50)]
        public string City { get; set; }
        [MaxLength(50)]
        public string State { get; set; }
        [MaxLength(50)]
        public string PostalCode { get; set; }
        [MaxLength(50)]
        public string Country { get; set; }
        [MaxLength(50)]
        public string AddressType { get; set; }
        [MaxLength(50)]
        public string StreetAddress { get; set; }
        [MaxLength(50)]
        public string ApartmentNumber { get; set; }

        public List<Client_Address> ClientAddressList { get; set; }
        public List<Company_Address> CompanyAddressList { get; set; }
        public List<Agent_Address> AgentAddressList { get; set; }
    }
}
