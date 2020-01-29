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
using PRAXYS.Commons.Entities.SubAgent;
using PRAXYS.Shared.Entities;

namespace PRAXYS.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class SubAgentsController : ControllerBase
    {
        private ISubAgentBLC _subagentBLC;
        private IMapper _mapper;

        public SubAgentsController(ISubAgentBLC subAgentBLC, IMapper mapper)
        {
            this._subagentBLC = subAgentBLC;
            this._mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SubAgentModel>>> GetAll()
        {
            var subAgents = await _subagentBLC.GetAll();
            return _mapper.Map<List<SubAgentModel>>(subAgents);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SubAgentModel>> Get(int id)
        {
            var agent = await _subagentBLC.Get(id);
            return _mapper.Map<SubAgentModel>(agent);
        }

        [HttpPost]
        public async Task<ActionResult<bool>> Post(SubAgentModel subAgentModel) 
        {
            if(!await _subagentBLC.Post(subAgentModel)){
                return BadRequest();
            }

            return true;
        }

        [HttpPut]
        public async Task<ActionResult<bool>> Put(int id, SubAgentModel subAgentModel)
        {
            if (id != subAgentModel.ID)
            {
                return BadRequest();
            }

            if (!await _subagentBLC.Put(id,subAgentModel))
            {
                return BadRequest();
            }

            return true;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            if (!await _subagentBLC.Delete(id))
            {
                return BadRequest();
            }

            return true;
        }
    }
}