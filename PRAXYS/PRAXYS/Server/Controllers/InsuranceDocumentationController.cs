using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PRAXYS.Business;
using PRAXYS.Business.Interfaces;
using PRAXYS.Commons.Entities.Insurance;
using PRAXYS.Shared.Entities;

namespace PRAXYS.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class InsuranceDocumentationController : ControllerBase
    {
        private IInsuranceDocumentationBLC _insurancBLC;

        public InsuranceDocumentationController(IInsuranceDocumentationBLC documentationBLC, IMapper mapper)
        {
            this._insurancBLC = documentationBLC;
        }

        [Route("[action]/{id}")]
        [HttpGet]
        public async Task<ActionResult<List<InsuranceDocumentationModel>>> GetAllByID(int id)
        {
            var documentation = await _insurancBLC.GetAllByID(id);
            return documentation;
        }

        [HttpPost]
        public async Task<ActionResult<InsuranceDocumentationModel>> Post(InsuranceDocumentationModel model)
        {
            //var document = _mapper.Map<InsuranceDocumentation>(model);
            if(!await _insurancBLC.PostInsuranceDocument(model))
            {
                return BadRequest();
            }

            return model;
        }

        [Route("{id}")]
        [HttpDelete]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            var result = await _insurancBLC.Delete(id);
            if (result)
            {
                return BadRequest();
            }

            return true;
        }

        [Route("[action]/{id}")]
        [HttpGet]
        public async Task<ActionResult<string>> DownloadFile(int id)
        {
            var documentationUrl = await _insurancBLC.DowloadDocument(id);
            return documentationUrl;
        }

        [Route("[action]/{id}")]
        [HttpGet]
        public async Task<ActionResult<InsuranceDocumentationModel>> DownloadDocument(int id)
        {
            var documentation = await _insurancBLC.DowloadDocumentFile(id);
            return documentation;
        }

        [Route("[action]/{id}")]
        [HttpGet]
        public async Task<ActionResult<InsuranceDocumentationModel>> ViewDocument(int id)
        {
            var documentation = await _insurancBLC.ViewDocumentFile(id);
            return documentation;
        }
    }
}