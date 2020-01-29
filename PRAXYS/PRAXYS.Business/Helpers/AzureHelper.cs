using Microsoft.Extensions.Configuration;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using PRAXYS.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRAXYS.Business.Helpers
{
    public class AzureHelper : IFilesRepository
    {
        private string connectionString;

        public AzureHelper(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("AzureStorage");
        }

        private CloudBlobClient CreateCloudBlobClient()
        {
            try
            {
                var storageAccount = CloudStorageAccount.Parse(connectionString);
                var blobClient = storageAccount.CreateCloudBlobClient();

                return blobClient;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public async Task<string> SaveDocument(byte[] content, string extension, string nombreContenedor)
        {
            var blobClient = CreateCloudBlobClient();

            var container = blobClient.GetContainerReference(nombreContenedor);

            var nombreArchivo = $"{nombreContenedor.ToUpper()}-{GenerateRandomNo()}.{extension}";
            var blob = container.GetBlockBlobReference(nombreArchivo);
            if (!await blob.ExistsAsync())
            {
                await blob.UploadFromByteArrayAsync(content, 0, content.Length);
                return blob.Uri.ToString();
            }

            return "";
        }


        public async Task<bool> DeleteDocument(string ruta, string nombreContenedor)
        {
            var blobClient = CreateCloudBlobClient();

            var container = blobClient.GetContainerReference(nombreContenedor);
            var blobName = Path.GetFileName(ruta);
            var blob = container.GetBlobReference(blobName);
            if (await blob.ExistsAsync())
            {
                await blob.DeleteAsync();
                return true;
            }
            else
            {
                return false;
            }

        }

        public async Task<string> DownloadDocument(string ruta, string nombreContenedor)
        {
            try
            {
                var blobClient = CreateCloudBlobClient();

                var container = blobClient.GetContainerReference(nombreContenedor);
                var blobName = Path.GetFileName(ruta);
                var blob = container.GetBlobReference(blobName);
                if (await blob.ExistsAsync())
                {
                    blob.Properties.ContentType = "application/octet-stream";
                    await blob.SetPropertiesAsync();

                    return blob.Uri.ToString();
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {

                return null;
            }
        }
        

        public async Task<string> ViewFile(string url, string containerName)
        {
            try
            {
                var blobClient = CreateCloudBlobClient();

                var container = blobClient.GetContainerReference(containerName);
                var blobName = Path.GetFileName(url);
                var extension = Path.GetExtension(blobName); 
                var blob = container.GetBlobReference(blobName);
                if (await blob.ExistsAsync())
                {
                    blob.Properties.ContentType = GetFileContentType(extension);
                    await blob.SetPropertiesAsync();

                    return blob.Uri.ToString();
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {

                return null;
            }
        }

        public async Task<bool> DeleteFile(string url, string containerName)
        {
            var blobClient = CreateCloudBlobClient();

            var container = blobClient.GetContainerReference(containerName);
            var blobName = Path.GetFileName(url);
            var blob = container.GetBlobReference(blobName);
            if (await blob.ExistsAsync())
            {
                await blob.DeleteAsync();
                return true;
            }
            else
            {
                return false;
            }
        }

        public Task<string> SaveFile(MemoryStream file, byte[] content, string extension, string containerName, string blobReference)
        {
            throw new NotImplementedException();
        }

        private static string GetFileContentType(string extension)
        {
            string contentType = "";

            switch (extension)
            {
                case ".pdf":
                    contentType = "application/pdf";
                    break;
                case ".jpg":
                    contentType = "image/jpeg";
                    break;
                case ".jpeg":
                    contentType = "image/jpeg";
                    break;
                case ".png":
                    contentType = "image/png";
                    break;
            }

            return contentType;
        }

        private int GenerateRandomNo()
        {
            int _min = 1000;
            int _max = 9999;
            Random _rdm = new Random();
            return _rdm.Next(_min, _max);
        }

        Task IFilesRepository.DeleteFile(string url, string containerName)
        {
            throw new NotImplementedException();
        }
    }
}
