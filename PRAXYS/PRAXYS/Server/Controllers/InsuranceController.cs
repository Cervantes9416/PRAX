using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PRAXYS.Business;
using PRAXYS.Business.Interfaces;
using PRAXYS.Commons.Entities;
using PRAXYS.Commons.Entities.Insurance;
using PRAXYS.Commons.Filter;
using PRAXYS.Shared.Entities;

namespace PRAXYS.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]         

    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class InsuranceController : ControllerBase
    {
        private IInsuranceBLC _insuranceBLC;
        private IMapper _mapper;
        private IReportBLC _report;

        public InsuranceController(IInsuranceBLC insuranceBLC, IMapper mapper, IReportBLC report)
        {
            this._insuranceBLC = insuranceBLC;
            this._mapper = mapper;
            this._report = report;
        }

        [HttpGet]
        public async Task<List<InsuranceModel>> GetAll()
        {
            var insurances = await _insuranceBLC.GetAll();
            return _mapper.Map<List<InsuranceModel>>(insurances);
        }

        [Route("[action]/{insuranceNumber}")]
        [HttpGet]
        public async Task<List<InsuranceEndorsementModel>> GetAllByInsuranceNumber(string insuranceNumber)
        {
            var insurances = await _insuranceBLC.GetAllWithInsuranceNumber(insuranceNumber);
            return insurances;

            //return _mapper.Map<List<InsuranceModel>>(insurances);
        }

        [Route("[action]")]
        [HttpGet]
        public async Task<ActionResult<List<InsuranceListModel>>> GetAllWithoutEndorsement()
          {
            var insurances = await _insuranceBLC.GetAllWithoutEndorsement();
            return _mapper.Map<List<InsuranceListModel>>(insurances);
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<List<InsuranceListModel>> GetAllByFilter(InsuranceFilter filter)
        {
            var insurances = await _insuranceBLC.GetAllByFilter(filter);
            return _mapper.Map<List<InsuranceListModel>>(insurances);
        }

        [Route("[action]")]
        [HttpGet]
        public async Task<List<InsuranceModel>> GetAllByDetail()
        {
            var insurances = await _insuranceBLC.GetAllByDetails();
            return _mapper.Map<List<InsuranceModel>>(insurances);
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<List<InsuranceCardModel>>> GetInsuranceNextToExpire(DatePickerModel datePickerModel)
        {
            var insurance = _insuranceBLC.GetInsuranceNextToExpire(datePickerModel);
            return await insurance;
        }

        [Route("[action]/{AgentID}")]
        [HttpGet]
        public async Task<ActionResult<List<InsuranceListModel>>> GetAllByClientID(int AgentID)
        {
            var insurances = await _insuranceBLC.GetAllByAgentID(AgentID);
            return _mapper.Map<List<InsuranceListModel>>(insurances);
        }

        [Route("[action]/{AgentID}")]
        [HttpGet]
        public async Task<ActionResult<List<InsuranceListModel>>> GetAllByAgentID(int AgentID)
        {
            var insurances = await _insuranceBLC.GetAllByAgentID(AgentID);
            return _mapper.Map<List<InsuranceListModel>>(insurances);
        }

        [Route("[action]/{CompanyID}")]
        [HttpGet]
        public async Task<ActionResult<List<InsuranceListModel>>> GetAllByCompanyID(int CompanyID)
        {
            var insurances = await _insuranceBLC.GetAllByCompanyID(CompanyID);
            return _mapper.Map<List<InsuranceListModel>>(insurances);
        }

        [Route("[action]/{SubAgentID}")]
        [HttpGet]
        public async Task<ActionResult<List<InsuranceListModel>>> GetAllBySubAgentID(int SubAgentID)
        {
            var insurances = await _insuranceBLC.GetAllBySubAgentID(SubAgentID);
            return _mapper.Map<List<InsuranceListModel>>(insurances);
        }

        [Route("[action]")]
        [HttpGet]
        public async Task<ActionResult<List<InsuranceListModel>>> GetListModels()
        {
            _report.ReportValid();
            var agents = await _insuranceBLC.GetAllByDetails();
            return _mapper.Map<List<InsuranceListModel>>(agents);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<InsuranceModel>> Get(int id)
        {
            var insurance = await _insuranceBLC.Get(id);
            return _mapper.Map<InsuranceModel>(insurance);
        }

        [HttpGet("[action]/{id}")]
        public async Task<ActionResult<InsuranceModel>> GetByDetails(int id)
        {
            var insurance = await _insuranceBLC.GetByDetails(id);
            return _mapper.Map<InsuranceModel>(insurance);
        }

        [HttpPost("Create")]
        public async Task<ActionResult<InsuranceModel>> Post(InsuranceModel insuranceModel)
        {
            var insurance = _mapper.Map<Insurance>(insuranceModel);
            var newInsuarance = await _insuranceBLC.Post(insurance);
            if (newInsuarance == null)
            {
                return BadRequest();
            }
            return insuranceModel;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            var result = await _insuranceBLC.Delete(id);
            if (result == null)
            {
                return BadRequest();
            }

            return true;
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<bool>> Put(int id, InsuranceModel insurance)
        {
            if (id != insurance.ID)
            {
                return BadRequest();
            }
            var item = _mapper.Map<Insurance>(insurance);
            var result = await _insuranceBLC.Put(id,item);
            
            if (result == null)
            {
                return false;
            }

            return true;
        }

        [HttpPost("[action]")]
        public async Task<ActionResult<bool>> CancelInsurance(InsuranceModel item)
        {
            var result = await _insuranceBLC.CancelInsurance(item);

            if (result)
            {
                return false;
            }

            return true;
        }

        #region Report Section

        [Route("[action]")]
        [HttpPost]
        public async Task<bool> GenerateValidReport(ReportFilterModel reportFilter)
        {
            //_report.ReportValid();
            await _report.GetReportByFilter(reportFilter);
            return true;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<List<InsuranceListModel>> ReportValidInsurance()
        {
            var insurances = await _insuranceBLC.GetAll();
            return _mapper.Map<List<InsuranceListModel>>(insurances);
        }

        #endregion
    }
}
