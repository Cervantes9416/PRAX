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
using PRAXYS.Commons.Entities.Agent;
using PRAXYS.Data;
using PRAXYS.Data.DALC;
using PRAXYS.Shared.Entities;

namespace PRAXYS.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class AgentsController : ControllerBase
    {
        private IAgentBLC _agentBLC;
        private IMapper _mapper;

        public AgentsController(IAgentBLC agentBLC, IMapper mapper)
        {
            this._agentBLC = agentBLC;
            this._mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<AgentModel>>> GetAll()
        {
            var agents = await _agentBLC.GetAll();
            return _mapper.Map<List<AgentModel>>(agents);
        }

        [Route("[action]")]
        [HttpGet]
        public async Task<ActionResult<List<AgentModel>>> GetAllByDetails()
        {
            var agents = await _agentBLC.GetAllByDetails();
            return _mapper.Map<List<AgentModel>>(agents);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AgentModel>> Get(int id)
        {
            var agents = await _agentBLC.Get(id);
            return _mapper.Map<AgentModel>(agents);
        }

        [HttpPost]
        public async Task<ActionResult<bool>> Post(AgentModel agentModel)
        {
            if(!await _agentBLC.Post(agentModel))
            {
                return BadRequest();
            }
            return true;
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<bool>> Put(int id, AgentModel agentModel)
        {
            if (id != agentModel.ID)
            {
                return false;
            }

            if (!await _agentBLC.Put(id,agentModel))
            {
                return false;
            }
            return true;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            var result = await _agentBLC.Delete(id);
            if (!result)
            {
                return false;
            }

            return true;
        }
    }
}
