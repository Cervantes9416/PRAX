using System;
using System.Collections.Generic;
using System.Text;

namespace PRAXYS.Commons.Interfaces
{
    public interface IDocumentationEntity
    {
        int ID { get; set; }
        string FileName { get; set; }
        DateTime SavedDate { get; set; }
        string Notes { get; set; }
        string FileExtension { get; set; }
        string Url { get; set; }
        string fileBase64 { get; set; }
        string containerName { get; set; }
    }
}
