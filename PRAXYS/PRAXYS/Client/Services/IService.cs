using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRAXYS.Client.Services
{
    public interface IService
    {
        Task<HttpResponseWrapper<object>> POST<T>(string url, T enviar);
    }
}
