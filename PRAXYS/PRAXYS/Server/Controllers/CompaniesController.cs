using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PRAXYS.Business.Interfaces;
using PRAXYS.Commons.Entities.Company;
using PRAXYS.Data;
using PRAXYS.Data.DALC;
using PRAXYS.Shared.Entities;

namespace PRAXYS.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class CompaniesController : ControllerBase
    {
        private ICompanyBLC _companyBLC;

        public CompaniesController(ICompanyBLC companyBLC, IMapper mapper)
        {
            this._companyBLC = companyBLC;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CompanyModel>>> GetAll()
        {
            return await _companyBLC.GetAll();
        }

        [HttpGet("[action]")]
        public async Task<ActionResult<IEnumerable<CompanyModel>>> GetAllByDetails()
        {
            return await _companyBLC.GetAllByDetails();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CompanyModel>> Get(int id)
        {
            return await _companyBLC.GetByDetail(id);
        }

        [HttpGet("[action]/{id}")]
        public async Task<ActionResult<CompanyModel>> GetByDetails(int id)
        {
            return await _companyBLC.GetByDetail(id);
        }

        [HttpPost]
        public async Task<ActionResult<bool>> Post(CompanyModel companyModel)
        {
            if (!await _companyBLC.Post(companyModel))
            {
                return BadRequest();
            }

            return true;
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<bool>> Put(int id, CompanyModel companyModel)
        {
            if (id != companyModel.ID)
            {
                return false;
            }

            if (!await _companyBLC.Put(id, companyModel))
            {
                return false;
            }

            return true;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            if (!await _companyBLC.Delete(id))
            {
                return false;
            }

            return true;
        }
    }
}
