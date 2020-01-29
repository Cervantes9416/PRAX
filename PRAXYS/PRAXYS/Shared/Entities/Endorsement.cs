using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PRAXYS.Shared.Entities
{
    public class Endorsement
    {
        public int ID { get; set; }
        [Required]
        public int InsuranceID { get; set; }
        [Required]
        public DateTime ValidFrom { get; set; }
        [Required]
        public DateTime ValidThrought { get; set; }
        [Required]
        public int EndorsementTypeID { get; set; }
        [Required]
        public string Description { get; set; }
        
        public Insurance Insurance { get; set; }
        public EndorsementType EndorsementType { get; set; }
    }
}
