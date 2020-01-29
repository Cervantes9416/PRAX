using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PRAXYS.Business.Interfaces;
using PRAXYS.Commons.Entities.Client;
using PRAXYS.Data.Intefaces;
using PRAXYS.Shared.Entities;

namespace PRAXYS.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class ClientDocumentationController : ControllerBase
    {
        private IClientDocumentationBLC _clientDocumentationBLC;
        private IMapper _mapper;

        public ClientDocumentationController(IClientDocumentationBLC clientDocumentationBLC ,IMapper mapper)
        {
            this._clientDocumentationBLC = clientDocumentationBLC;
            this._mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<ClientDocumentationModel>>> GetAll()
        {
            var documentation = await _clientDocumentationBLC.GetAll();
            return documentation;
        }

        [Route("[action]/{id}")]
        [HttpGet]
        public async Task<ActionResult<List<ClientDocumentationModel>>> GetAllByID(int id)
        {
            var documentation = await _clientDocumentationBLC.GetAllByID(id);
            return documentation;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ClientDocumentationModel>> Get(int id)
        {
            var document = await _clientDocumentationBLC.Get(id);
            return document;
        }

        [Route("[action]/{id}")]
        [HttpGet]
        public async Task<ActionResult<ClientDocumentationModel>> DownloadFile(int id)
        {
            var document = await _clientDocumentationBLC.DownloadFile(id);
            return document;
        }

        [Route("[action]/{id}")]
        [HttpGet]
        public async Task<ActionResult<ClientDocumentationModel>> ViewFile(int id)
        {
            var document = await _clientDocumentationBLC.ViewFile(id);
            return document;
        }

        [HttpPost]
        public async Task<ActionResult<ClientDocumentationModel>> Post(ClientDocumentationModel model)
        {
            //var item = _mapper.Map<ClientDocumentation>(model);
            await _clientDocumentationBLC.Post(model);
            return model;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            if(!await _clientDocumentationBLC.DeleteDocument(id))
            {
                return BadRequest();
            }

            return true;
        }
    }
}