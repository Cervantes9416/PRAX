using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PRAXYS.Business.Interfaces;
using PRAXYS.Commons.Entities.Bond;
using PRAXYS.Commons.Entities.BondPayment;
using PRAXYS.Commons.Entities.ComissionPayment;

namespace PRAXYS.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class BondsController : ControllerBase
    {
        private IBondBLC _bondBLC;
        private IBondPayment _bondPaymentBLC;
        private IComissionPaymentBLC _comissionPaymentBLC;

        public BondsController(IBondBLC bondBLC, IBondPayment bondPayment, IComissionPaymentBLC comission)
        {
            this._bondBLC = bondBLC;
            this._bondPaymentBLC = bondPayment;
            this._comissionPaymentBLC = comission;
        }

        [HttpGet]
        public async Task<ActionResult<List<BondListModel>>> GetAllBonds()
        {
            return await _bondBLC.GetAll();
        }

        [Route("{BondID}")]
        [HttpGet]
        public async Task<ActionResult<BondModel>> Get(int BondID)
        {
            return await _bondBLC.Get(BondID);
        }

        [Route("[action]/{BondID}")]
        [HttpGet]
        public async Task<ActionResult<BondModel>> GetWithDetails(int BondID)
        {
            return await _bondBLC.GetWithDetails(BondID);
        }

        [HttpPost("Create")]
        public async Task<ActionResult<BondModel>> Post(BondModel model)
        {
            return await _bondBLC.Post(model);
        }

        #region SECTION BOND PAYMENT
        
        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<bool>> PostBondPayment(BondPaymentModel model)
        {
            if(!await _bondPaymentBLC.Post(model))
            {
                return BadRequest();
            }

            return true;
        }

        #endregion

        #region SECTION COMISSION PAYMENT

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<bool>> PostComissionPayment(ComissionPaymentModel model)
        {
            if ( !await _comissionPaymentBLC.CreateComissionPayment(model))
            {
                return BadRequest();
            }
            return true;
        }

        #endregion
    }
}