using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PRAXYS.Commons.Entities.Address
{
    public class AddressModel
    {
        public int ID { get; set; }
        /*public string Street { get; set; }
        public string Colony { get; set; }*/
        [MaxLength(200)]
        public string AddressLine { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string AddressType { get; set; }
        public string StreetAddress { get; set; }
        public string ApartmentNumber { get; set; }
    }
}
