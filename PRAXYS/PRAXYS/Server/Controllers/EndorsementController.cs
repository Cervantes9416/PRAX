using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PRAXYS.Business.Interfaces;
using PRAXYS.Commons.Entities.Endorsement;

namespace PRAXYS.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class EndorsementController : ControllerBase
    {
        private readonly IEndorsementBLC _endorsementBLC;

        public EndorsementController(IEndorsementBLC endorsement)
        {
            this._endorsementBLC = endorsement;
        }

        [HttpGet]
        public async Task<ActionResult<List<EndorsementModel>>> GetAll()
        {
            return new List<EndorsementModel>();
        }

       
        [HttpPost]
        public async Task<ActionResult<bool>> Post(EndorsementModel endorsementModel)
        {
            if (!await _endorsementBLC.CreateEndorsement(endorsementModel))
            {
                return BadRequest();
            }
            return true;
        }

        [Route("[action]/{id}")]
        [HttpPost]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            return await _endorsementBLC.DeleteEndorsement(id);
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<bool>> CreateEndorsementModification(ModificationEndorsementRequest model)
        {
            if (!await _endorsementBLC.CreateEndorsementModification(model))
            {
                return BadRequest();
            }
            return true;
        }

        #region Endorsement Type Methods
        [Route("[action]")]
        [HttpGet]
        public async Task<ActionResult<List<EndorsementTypeModel>>> GetAllEndorsementType()
        {
            return await _endorsementBLC.GetAllEndorsementType();
        }
        #endregion

    }
}