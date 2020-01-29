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
using PRAXYS.Commons.Entities.CoveragePlan;
using PRAXYS.Data;
using PRAXYS.Data.DALC;
using PRAXYS.Shared.Entities;

namespace PRAXYS.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class CoveragePlansController : ControllerBase
    {
        private ICoveragePlanBLC _coveragePlanBLC;
        private IMapper _mapper;

        public CoveragePlansController(ICoveragePlanBLC coveragePlanBLC, IMapper mapper)
        {
            this._coveragePlanBLC = coveragePlanBLC;
            this._mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CoveragePlanModel>>> GetAll()
        {
            var coveragePlan = await _coveragePlanBLC.GetAll();
            return _mapper.Map<List<CoveragePlanModel>>(coveragePlan);
        }

        [Route("[action]")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CoveragePlanModel>>> GetAllByDetails()
        {
            var coveragePlans = await _coveragePlanBLC.GetAllByDetails();
            return _mapper.Map<List<CoveragePlanModel>>(coveragePlans);
        }

        [Route("[action]/{RamoID}")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CoveragePlanModel>>> GetCoveragePlansByRamo(int RamoID)
        {
            var coveragePlans = await _coveragePlanBLC.GetCoveragePlansByRamo(RamoID);
            return _mapper.Map<List<CoveragePlanModel>>(coveragePlans);
        }

        [Route("{id}")]
        [HttpGet]
        public async Task<ActionResult<CoveragePlan>> Get(int id)
        {
            return await _coveragePlanBLC.Get(id);
        }

        [Route("[action]/{id}")]
        [HttpGet]
        public async Task<ActionResult<CoveragePlan>> GetByDetails(int id)
        {
            return await _coveragePlanBLC.Get(id);
        }

        [HttpPost]
        public async Task<ActionResult<CoveragePlan>> Post(CoveragePlanModel coveragePlanModel)
        {
            var coveragePlan = _mapper.Map<CoveragePlan>(coveragePlanModel);
            return await _coveragePlanBLC.Post(coveragePlan);
        }
    }
}
