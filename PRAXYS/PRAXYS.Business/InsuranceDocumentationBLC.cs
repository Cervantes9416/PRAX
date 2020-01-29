using AutoMapper;
using PRAXYS.Business.Helpers;
using PRAXYS.Business.Interfaces;
using PRAXYS.Commons.Entities.BondPayment;
using PRAXYS.Commons.Entities.Insurance;
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
    public class InsuranceDocumentationBLC : IInsuranceDocumentationBLC
    {
        private AppDbContext _context;
        private IMapper _mapper;
        private IFilesRepository _fileRepository;

        public InsuranceDocumentationBLC(
            IMapper mapper,
            IFilesRepository filesRepository,
            AppDbContext context )
        {
            this._context = context;
            this._mapper = mapper;
            this._fileRepository = filesRepository;
        }

        public async Task<bool> Delete(int id)
        {
            var document = await _context.InsuranceDocumentGet(id);
            if(await _fileRepository.DeleteDocument(document.Url, "poliza"))
            {
                return await _context.InsuranceDocumentDelete(id);
            }

            return false;
        }

        public async Task<InsuranceDocumentationModel> Get(int id)
        {
            var document =  await _context.InsuranceDocumentGet(id);
            return _mapper.Map<InsuranceDocumentationModel>(document);
        }

        public async Task<List<InsuranceDocumentationModel>> GetAll()
        {
            var documents = await _context.InsuranceDocumentGetAll();
            return _mapper.Map<List<InsuranceDocumentationModel>>(documents);
        }

        public async Task<List<InsuranceDocumentationModel>> GetAllByID(int id)
        {
            var documents =  await _context.InsuranceDocumentGetAllByID(id);
            return _mapper.Map<List<InsuranceDocumentationModel>>(documents);
        }

        public async Task<string> DowloadDocument(int id)
        {
            var document = await _context.InsuranceDocumentGet(id);
            var url = await _fileRepository.DownloadDocument(document.Url,"poliza");
            return url;
        }

        public async Task<InsuranceDocumentationModel> DowloadDocumentFile(int id)
        {
            var document = await _context.InsuranceDocumentGet(id);
            var url = await _fileRepository.DownloadDocument(document.Url, "poliza");
            return _mapper.Map<InsuranceDocumentationModel>(document);
        }

        public async Task<InsuranceDocumentationModel> ViewDocumentFile(int id)
        {
            var document = await _context.InsuranceDocumentGet(id);
            var url = await _fileRepository.ViewFile(document.Url, "poliza");
            return _mapper.Map<InsuranceDocumentationModel>(document);
        }

        public async Task<bool> PostInsuranceDocument(InsuranceDocumentationModel item)
        {
            if (!string.IsNullOrEmpty(item.fileBase64))
            {
                var ByteFile = Convert.FromBase64String(item.fileBase64);
                var url = await _fileRepository.SaveDocument(ByteFile,"pdf","poliza");

                item.Url = url;

                var document = _mapper.Map<InsuranceDocumentation>(item);
                return await _context.InsuranceDocumentPost(document);
            }
            else
            {
                return false;
            }
        }
    }
}
