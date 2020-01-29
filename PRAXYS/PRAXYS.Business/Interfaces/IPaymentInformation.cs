using PRAXYS.Commons.Entities.PaymentInformation;
using PRAXYS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PRAXYS.Business.Interfaces
{
    public interface IPaymentInformation : IGenericBLC<PaymentInformation>
    {
        Task<List<PaymentInformationModel>> GetAllInsurancePayments(int id);
        Task<List<PaymentInformationModel>> GetAllWithInsuranceNumber(string InsuranceNumber);
    }
}
