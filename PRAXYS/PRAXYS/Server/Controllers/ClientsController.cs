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
using PRAXYS.Commons.Entities.Client;
using PRAXYS.Data;
using PRAXYS.Data.DALC;
using PRAXYS.Shared.Entities;

namespace PRAXYS.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class ClientsController : ControllerBase
    {
        private IClientBLC _clientBLC;
        private IMapper _mapper;

        public ClientsController(
            IClientBLC clientBLC, 
            IMapper mapper)
        {
            this._clientBLC = clientBLC;
            this._mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClientModel>>> GetAll()
        {
            var clients = await _clientBLC.GetAll();
            return _mapper.Map<List<ClientModel>>(clients);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ClientModel>> Get(int id)
        {
            var client = await _clientBLC.Get(id);
            return _mapper.Map<ClientModel>(client);
        }

        [Route("[action]/{id}")]
        [HttpGet]
        public async Task<ActionResult<ClientModel>> GetByDetails(int id)
        {
            var client = await _clientBLC.GetByDetails(id);
            var clientmodel = _mapper.Map<ClientModel>(client);
            return clientmodel;
        }

        [HttpPost]
        public async Task<ActionResult<ClientModel>> Post(ClientModel clientModel)
        {
            var result = await _clientBLC.Post(clientModel);

            if (result == null)
            {
                return BadRequest();
            }

            return result;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ClientModel>> Delete(int id)
        {
            var client = await _clientBLC.Delete(id);
            return _mapper.Map<ClientModel>(client);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<bool>> Put(int id, ClientModel client)
        {
            if (id != client.ID)
            {
                return BadRequest();
            }

            var result = await _clientBLC.Put(id,client);
            if (!result)
            {
                return BadRequest();
            }

            return result;
        }
    }
}
