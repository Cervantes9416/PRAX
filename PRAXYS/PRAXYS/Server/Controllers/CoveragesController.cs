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
using PRAXYS.Commons.Entities;
using PRAXYS.Data;
using PRAXYS.Data.DALC;

using PRAXYS.Shared.Entities;

namespace PRAXYS.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class CoveragesController : ControllerBase
    {
        private ICoverageBLC _coverageBLC;
        private IMapper _mapper;

        public CoveragesController(ICoverageBLC coverageBLC, IMapper mapper)
        {
            this._coverageBLC = coverageBLC;
            this._mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CoverageModel>>> GetAll()
        {
            var coverages = await _coverageBLC.GetAll();
            return _mapper.Map<List<CoverageModel>>(coverages);
        }

        [Route("[action]")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CoverageModel>>> GetAllByDetails()
        {
            var coverages = await _coverageBLC.GetAllByDeatils();
            return _mapper.Map<List<CoverageModel>>(coverages);
        }

        [Route("[action]/{RamoID}")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CoverageModel>>> GetAllByRamo(int RamoID)
        {
            var coverages = await _coverageBLC.GetCoverageByRamo(RamoID);
            return _mapper.Map<List<CoverageModel>>(coverages);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Coverage>> Get(int id)
        {
            return await _coverageBLC.Get(id);
        }

        [HttpPost]
        public async Task<ActionResult<Coverage>> Post(CoverageModel coverageModel)
        {
            var coverage = _mapper.Map<Coverage>(coverageModel);
            return await _coverageBLC.Post(coverage);
        }
    }
}
