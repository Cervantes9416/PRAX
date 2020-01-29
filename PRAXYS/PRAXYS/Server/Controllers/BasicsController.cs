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
using PRAXYS.Commons.Entities.PaymentType;

namespace PRAXYS.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class BasicsController : ControllerBase
    {
        private readonly IPaymentTypeBLC _paymentTypeBLC;
        private readonly IBranchBLC _branchBLC;

        public BasicsController(IPaymentTypeBLC paymentTypeBLC,
            IBranchBLC branchBLC)
        {
            this._paymentTypeBLC = paymentTypeBLC;
            this._branchBLC = branchBLC;
        }

        [Route("[action]")]
        [HttpGet]
        public async Task<ActionResult<List<PaymentTypeModel>>> GetAllPaymentTypes()
        {
            return await _paymentTypeBLC.GetAll();
        }

        [Route("[action]/{id}")]
        [HttpGet]
        public async Task<ActionResult<PaymentTypeModel>> GetPaymentType(int id)
        {
            return await _paymentTypeBLC.Get(id);
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<PaymentTypeModel>> PostPaymentType(PaymentTypeModel item)
        {
            return await _paymentTypeBLC.Post(item);
        }

        [Route("[action]/{id}")]
        [HttpDelete]
        public async Task<ActionResult<bool>> DeletePaymentType(int id)
        {
            return await _paymentTypeBLC.DeletePayment(id);
        }


        [Route("[action]/{id}")]
        [HttpPut]
        public async Task<ActionResult<bool>> PutPaymentType(int id,PaymentTypeModel item)
        {
            if (id != item.ID)
            {
                return BadRequest();
            }



            return await _paymentTypeBLC.DeletePayment(id);
        }

        //-------------------------BRANCH

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<bool>> PostBranch(BranchModel item)
        {
            var result = await _branchBLC.PostBranch(item);
            if (!result)
            {
                return BadRequest();
            }

            return result;
        }

        [Route("[action]/{id}")]
        [HttpDelete]
        public async Task<ActionResult<bool>> DeleteBranch(int id)
        {
            var result = await _branchBLC.DeleteBranch(id);
            if (!result)
            {
                return BadRequest();
            }

            return result;
        }

        [Route("[action]/{id}")]
        [HttpDelete]
        public async Task<ActionResult<bool>> PutBranch(int id, BranchModel item)
        {
            if (id != item.ID)
            {
                return BadRequest();
            }
            
            if(!await _branchBLC.PutBranch(item))
            {
                return BadRequest();
            }

            return true;
        }

        //--------------------------SUB-BRANCH

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<bool>> PostSubBranch(SubBranchModel item)
        {
            var result = await _branchBLC.PostSubBranch(item);
            if (!result)
            {
                return BadRequest();
            }

            return result;
        }

        [Route("[action]/{id}")]
        [HttpDelete]
        public async Task<ActionResult<bool>> DeleteSubBranch(int id)
        {
            var result = await _branchBLC.DeleteSubBranch(id);
            if (!result)
            {
                return BadRequest();
            }

            return result;
        }

        [Route("[action]/{id}")]
        [HttpDelete]
        public async Task<ActionResult<bool>> PutSubBranch(int id, SubBranchModel item)
        {
            if (id != item.ID)
            {
                return BadRequest();
            }

            if (!await _branchBLC.PutSubBranch(item))
            {
                return BadRequest();
            }

            return true;
        }

    }
}