using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PRAXYS.Shared.Entities
{
    public class ClientDocumentation
    {
        public int ID { get; set; }
        [Required]
        public int ClientID { get; set; }
        [MaxLength(50)]
        public string FileName { get; set; }
        [Required]
        public DateTime SavedDate { get; set; }
        [MaxLength(150)]
        public string Notes { get; set; }
        [MaxLength(15)]
        public string FileExtension { get; set; }
        public string Url { get; set; }
        [MaxLength(30)]
        public string containerName { get; set; }

        public Clients Client { get; set; }
    }
}
