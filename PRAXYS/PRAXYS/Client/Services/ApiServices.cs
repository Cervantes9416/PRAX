using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PRAXYS.Client.Services
{
    public class ApiServices : IService
    {
        private HttpClient _http;

        public ApiServices(HttpClient httpClient)
        {
            this._http = httpClient;
        }

        public async Task<HttpResponseWrapper<object>> POST<T>(string url, T enviar)
        {
            var sendJson = JsonSerializer.Serialize(enviar);
            var sendContent = new StringContent(sendJson, Encoding.UTF8, "application/json");
            var responseHttp = await _http.PostAsync(url, sendContent);
            return new HttpResponseWrapper<object>(null, !responseHttp.IsSuccessStatusCode, responseHttp);
        }
    }
}
