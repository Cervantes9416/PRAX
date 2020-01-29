using PRAXYS.Commons.Entities.Address;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRAXYS.Client.Intefaces
{
    public interface IAddressList
    {
        List<AddressModel> AddressList { get; set; }
        void OnValidSubmitCreate();
    }
}
