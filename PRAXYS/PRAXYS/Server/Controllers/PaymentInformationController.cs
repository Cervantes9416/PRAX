using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PRAXYS.Business.Interfaces;
using PRAXYS.Commons.Entities.PaymentInformation;
using PRAXYS.Commons.Entities.RegisterPayment;
using PRAXYS.Data;
using PRAXYS.Shared.Entities;

namespace PRAXYS.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class PaymentInformationController : ControllerBase
    {
        private AppDbContext _context;
        private readonly IMapper _mapper;
        private readonly IPaymentInformation _paymentInformationBLC;

        public PaymentInformationController(AppDbContext appDbContext,
            IPaymentInformation paymentInformation,
            IMapper mapper)
        {
            this._context = appDbContext;
            this._mapper = mapper;
            this._paymentInformationBLC = paymentInformation;
        }

        [HttpGet]
        public async Task<List<PaymentInformationModel>> GetAll()
        {
            var payments = await _context.PaymentInformation
                .Include(x => x.Insurance)
                .ToListAsync();

            return _mapper.Map<List<PaymentInformationModel>>(payments);
        }

        [Route("[action]/{id}")]
        [HttpGet]
        public async Task<List<PaymentInformationModel>> GetAllInsurancePayments(int id)
        {
            return await _paymentInformationBLC.GetAllInsurancePayments(id);
        }

        [Route("[action]/{insuranceID}")]
        [HttpGet]
        public async Task<List<PaymentInformationModel>> GetAllWithInsurance(int insuranceID)
        {
            var payments = await _context.PaymentInformation
                .Include(x => x.Insurance)
                .Where(x => x.InsuranceID == insuranceID)
                .ToListAsync();

            return _mapper.Map<List<PaymentInformationModel>>(payments);
        }

        [HttpGet("{paymentID}")]
        public async Task<PaymentInformationModel> Get(int paymentID)
        {
            var payment = await _context.PaymentInformation
                .Include(x => x.RegisterPayment)
                .Include(x => x.Insurance)
                .Include(x => x.Insurance.Agent)
                .Include(x => x.Insurance.Client)
                .Include(x => x.Insurance.Company)
                .Where(x => x.ID == paymentID)
                .FirstOrDefaultAsync();

            var result = _mapper.Map<PaymentInformationModel>(payment);
            return result;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<bool> PayReceipt(InsurancePaymentModel insurancePayment)
        {
            var payment = _mapper.Map<RegisterPayment>(insurancePayment);
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var Receipt = _context.PaymentInformation
                        .Where(x => x.ID == insurancePayment.PaymentInformationID)
                        .FirstOrDefault();

                    payment.InsuranceID = Receipt.InsuranceID;
                    _context.RegisterPayment.Add(payment);

                    Receipt.Payed = true;

                    _context.Entry(Receipt).State = EntityState.Modified;
                    await _context.SaveChangesAsync();

                    if (!ValidatePayments(payment.InsuranceID))
                    {
                        var insurance = _context.Insurance
                            .Where(x => x.ID == payment.InsuranceID)
                            .FirstOrDefault();

                        insurance.Payed = true;
                        _context.Entry(insurance).State = EntityState.Modified;
                        await _context.SaveChangesAsync();
                    }

                    transaction.Commit();
                    return true;
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    return false;
                }
            }
        }

        private bool ValidatePayments(int insuranceID)
        {
            var payments = _context.PaymentInformation
                .Where(x => x.InsuranceID == insuranceID)
                .ToList();

            var result = payments.Any(x => x.Payed == false);
            return result;
        }
    }
}