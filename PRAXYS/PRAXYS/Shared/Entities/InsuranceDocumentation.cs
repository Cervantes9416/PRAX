using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PRAXYS.Shared.Entities
{
    public class InsuranceDocumentation
    {
        public int ID { get; set; }
        public int InsuranceID { get; set; }

        [Required]
        [MaxLength(50)]
        public string FileName { get; set; }
        [Required]
        public DateTime SavedDate { get; set; }
        public string Notes { get; set; }
        [Required]
        [MaxLength(15)]
        public string FileExtension { get; set; }
        [MaxLength(40)]
        public string Url { get; set; }
        [MaxLength(30)]
        public string containerName { get; set; }

        public Insurance Insurance { get; set; }
    }
}
