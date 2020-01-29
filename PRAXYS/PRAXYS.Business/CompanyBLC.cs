using AutoMapper;
using PRAXYS.Business.Interfaces;
using PRAXYS.Commons.Entities.BondPayment;
using PRAXYS.Commons.Entities.Company;
using PRAXYS.Data;
using PRAXYS.Data.DALC;
using PRAXYS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PRAXYS.Business
{
    public class CompanyBLC : ICompanyBLC
    {
        private readonly IMapper _mapper;
        private readonly AppDbContext _context;

        public CompanyBLC(AppDbContext context ,IMapper mapper)
        {
            this._mapper = mapper;
            this._context = context;
        }

        public async Task<bool> Delete(int id)
        {
            return await _context.CompanyDelete(id);
        }

        public Task<Company> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CompanyModel>> GetAll()
        {
            var companies = await _context.CompanyGetAll();
            return _mapper.Map<List<CompanyModel>>(companies);

        }

        public async Task<List<CompanyModel>> GetAllByDetails()
        {
            var companies = await _context.CompanyGetAllByDetails();
            return _mapper.Map<List<CompanyModel>>(companies);
        }
        public async Task<CompanyModel> GetByDetail(int id)
        {
            var company = await _context.CompanyGetByDetails(id);
            return _mapper.Map<CompanyModel>(company);
        }

        public async Task<bool> Post(CompanyModel item)
        {
            var company = _mapper.Map<Company>(item);
            return await _context.CompanyPost(company);
            
        }

        public async Task<bool> Put(int id, CompanyModel item)
        {
            var company = _mapper.Map<Company>(item);
            return await _context.CompanyPut(id, company);
        }

    }
}
