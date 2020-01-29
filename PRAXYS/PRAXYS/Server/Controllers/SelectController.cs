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
using PRAXYS.Commons.Entities.PaymentType;
using PRAXYS.Data.Intefaces;

namespace PRAXYS.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class SelectController : ControllerBase
    {
        private IPaymentTypeBLC _paymentBLC;
        private IMapper _mapper;

        public SelectController(
            IPaymentTypeBLC paymentTypeBLC,
            IMapper mapper)
        {
            this._paymentBLC = paymentTypeBLC;
            this._mapper = mapper;
        }

        #region Section PaymentType

        [Route("[action]")]
        [HttpGet]
        public async Task<ActionResult<List<PaymentTypeModel>>> GetSelectPaymentType()
        {
            var paymentTypes = await _paymentBLC.GetAll();
            return _mapper.Map<List<PaymentTypeModel>>(paymentTypes);
        }

        #endregion


    }
}