using PRAXYS.Commons.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PRAXYS.Commons.Entities.Client
{
    public class ClientDocumentationModel : IDocumentationEntity
    {
        public int ID { get; set; }
        public string FileName { get; set; }
        public DateTime SavedDate { get; set; }
        public string Notes { get; set; }
        public string FileExtension { get; set; }
        public string Url { get; set; }
        public string containerName { get; set; }
        public int ClientID { get; set; }

        public ClientModel Client { get; set; }
        public string fileBase64 { get; set; }
        
    }
}
