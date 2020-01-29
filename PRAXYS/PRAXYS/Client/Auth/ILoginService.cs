using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRAXYS.Client.Auth
{
    public interface ILoginService
    {
        Task Login(string token);
        Task Login(string token, DateTime expiration);
        Task Logout();
    }
}
