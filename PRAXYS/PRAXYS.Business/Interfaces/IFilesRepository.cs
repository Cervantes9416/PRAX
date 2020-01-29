using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace PRAXYS.Business.Interfaces
{
    public interface IFilesRepository
    {
        Task<bool> DeleteDocument(string ruta, string nombreContenedor);
        Task DeleteFile(string url, string containerName);
        Task<string> DownloadDocument(string ruta, string nombreContenedor);
        Task<string> SaveDocument(byte[] content, string extension, string nombreContenedor);
        Task<string> SaveFile(MemoryStream file, byte[] content, string extension, string containerName, string blobReference);
        Task<string> ViewFile(string url, string containerName);
    }
}
