using PRAXYS.Commons.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PRAXYS.Commons.Entities.Insurance
{
    public class InsuranceDocumentationModel : IDocumentationEntity
    {
        public int ID { get; set; }
        public int InsuranceID { get; set; }
        public string FileName { get; set; }
        public DateTime SavedDate { get; set; }
        public string Notes { get; set; }
        public string FileExtension { get; set; }
        public string Url { get; set; }
        public string fileBase64 { get; set; }
        public string DocumentType { get; set; }
        public string containerName { get; set; }

        public InsuranceModel Insurance { get; set; }
    }
}
