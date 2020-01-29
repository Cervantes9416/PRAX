using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PRAXYS.Shared.Entities
{
    public class Branch
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Alias { get; set; }

        public List<SubBranch> SubRamos { get; set; }
        public List<Ramo_Coverage> Ramo_Coverages { get; set; }
    }
}
