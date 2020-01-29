using AutoMapper;
using PRAXYS.Business.Helpers;
using PRAXYS.Business.Interfaces;
using PRAXYS.Commons.Entities.BondPayment;
using PRAXYS.Commons.Entities.Client;
using PRAXYS.Data;
using PRAXYS.Data.DALC;
using PRAXYS.Data.Intefaces;
using PRAXYS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PRAXYS.Business
{
    public class ClientDocumentationBLC : IClientDocumentationBLC
    {
        private readonly AppDbContext _context;
        private IMapper _mapper;
        private IFilesRepository _fileRepository;

        public ClientDocumentationBLC(
            AppDbContext context,
            IMapper mapper, 
            IFilesRepository filesRepository)
        {
            this._context = context;
            this._mapper = mapper;
            this._fileRepository = filesRepository;
        }

        
        public async Task<bool> DeleteDocument(int id)
        {
            var document = await _context.ClientDocumentationGet(id);
            if(await _fileRepository.DeleteDocument(document.Url, document.containerName))
            {
                await _context.ClientDocumentationDelete(id);
                return true;
            }

            return false;
        }

        public async Task<ClientDocumentationModel> Get(int id)
        {
            var files = await _context.ClientDocumentationGet(id);
            return _mapper.Map<ClientDocumentationModel>(files);
        }

        public async Task<List<ClientDocumentationModel>> GetAll()
        {
            var files = await _context.ClientDocumentationGetAll();
            return _mapper.Map<List<ClientDocumentationModel>>(files);
        }

        public async Task<List<ClientDocumentationModel>> GetAllByID(int id)
        {
            var files = await _context.ClientDocumentationGetAllByID(id);
            return _mapper.Map<List<ClientDocumentationModel>>(files);
        }

        public async Task<ClientDocumentation> Post(ClientDocumentationModel item)
        {
            if (!string.IsNullOrEmpty(item.fileBase64))
            {
                var ByteFile = Convert.FromBase64String(item.fileBase64);
                var url = await  _fileRepository.SaveDocument(ByteFile, "pdf", item.containerName);
                if (url != "")
                {
                    item.Url = url;

                    var document = _mapper.Map<ClientDocumentation>(item);
                    await _context.ClientDocumentationPost(document);
                }

                return null;
            }
            else
            {
                return null;
            }
        }

        public async Task<ClientDocumentationModel> DownloadFile(int id)
        {
            try
            {
                var document = await _context.ClientDocumentationGet(id);
                await _fileRepository.DownloadDocument(document.Url, document.containerName);
                return _mapper.Map<ClientDocumentationModel>(document);
            }
            catch (Exception)
            {

                return null;
            }
        }

        public async Task<ClientDocumentationModel> ViewFile(int id)
        {
            try
            {
                var document = await _context.ClientDocumentationGet(id);
                await _fileRepository.ViewFile(document.Url, document.containerName);
                return _mapper.Map<ClientDocumentationModel>(document);
            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}
