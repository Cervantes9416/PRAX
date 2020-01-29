using PRAXYS.Commons.Entities.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace PRAXYS.Commons.Interfaces
{
    public interface ISelectClient
    {
        int ClientID { get; set; }
        ClientModel Client { get; set; }
    }
}
