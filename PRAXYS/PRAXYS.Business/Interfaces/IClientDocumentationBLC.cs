using PRAXYS.Commons.Entities.Client;
using PRAXYS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PRAXYS.Business.Interfaces
{
    public interface IClientDocumentationBLC
    {
        Task<bool> DeleteDocument(int id);
        Task<ClientDocumentationModel> DownloadFile(int id);
        Task<ClientDocumentationModel> Get(int id);
        Task<List<ClientDocumentationModel>> GetAll();
        Task<List<ClientDocumentationModel>> GetAllByID(int id);
        Task<ClientDocumentation> Post(ClientDocumentationModel item);
        Task<ClientDocumentationModel> ViewFile(int id);
    }
}
