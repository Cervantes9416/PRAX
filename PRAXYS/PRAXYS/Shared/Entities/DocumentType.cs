using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PRAXYS.Shared.Entities
{
    public class DocumentType
    {
        public int ID { get; set; }
        [Required]
        public string Descripcion { get; set; }
    }
}
