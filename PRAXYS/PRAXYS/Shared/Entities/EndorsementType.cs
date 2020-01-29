using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PRAXYS.Shared.Entities
{
    public class EndorsementType
    {
        public int ID { get; set; }
        [Required]
        public string Descripcion { get; set; }
        [Required]
        public string Transaction  { get; set; }
    }
}
