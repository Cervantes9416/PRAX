using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PRAXYS.Business.Interfaces;
using PRAXYS.Commons.Entities.Branch;

namespace PRAXYS.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class BranchController : ControllerBase
    {
        private readonly IBranchBLC _branchBLC;

        public BranchController(IBranchBLC branchBLC)
        {
            this._branchBLC = branchBLC;
        }

        [Route("[action]")]
        [HttpGet]
        public async Task<ActionResult<List<BranchModel>>> GetAllBranchs()
        {
            return await _branchBLC.GetAllBranch();
        }

        #region SECTION SUB BRANCH

        [Route("[action]")]
        [HttpGet]
        public async Task<ActionResult<List<SubBranchModel>>> GetAllSubBranch()
        {
            return await _branchBLC.GetAllSubBranch();
        }

        [Route("[action]/{branchID}")]
        [HttpGet]
        public async Task<ActionResult<List<SubBranchModel>>> GetAllSubBranchWithBranchID(int branchID)
        {
            return await _branchBLC.GetAllSubBranchWithBranchID(branchID); 
        }

        [Route("[action]/{branchID}")]
        [HttpGet]
        public async Task<ActionResult<SubBranchModel>> GetSubBranch(int branchID)
        {
            return await _branchBLC.GetSubBranch(branchID);
        }

        #endregion
    }
}