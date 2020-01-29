using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.JSInterop;
using PRAXYS.Client.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text.Json;
using System.Threading.Tasks;

namespace PRAXYS.Client.Auth
{
    public class AuthenticationJWTProvider : AuthenticationStateProvider, ILoginService
    {
        public AuthenticationJWTProvider(IJSRuntime js, HttpClient Http)
        {
            this._http = Http;
            this.js = js;
        }

        public static readonly string TOKENKEY = "TOKENKEY";
        public static readonly string EXPIRATION = "EXPIRATION";
        private HttpClient _http;
        private IJSRuntime js;
        private AuthenticationState anonimo => new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));

        public async override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            //var token = await js.GetFromLocalStorage(TOKENKEY);
            var token = await GetTokenAsync();
            if (string.IsNullOrEmpty(token))
            {
                return anonimo;
            }

            return BuildAuthenticationState(token);
        }

        private AuthenticationState BuildAuthenticationState(string token)
        {
            _http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", token);
            return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity(ParseClaimsFromJwt(token).Result,"jwt")));
        }

        private async Task<IEnumerable<Claim>> ParseClaimsFromJwt(string jwt)
        {
            var claims = new List<Claim>();
            var payload = jwt.Split('.')[1];
            var jsonBytes = ParseBase64WithoutPadding(payload);
            var keyValuePairs = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonBytes);

            keyValuePairs.TryGetValue(ClaimTypes.Expiration, out object expiration);

            keyValuePairs.TryGetValue(ClaimTypes.Role, out object roles);

            if (roles != null)
            {
                if (roles.ToString().Trim().StartsWith("["))
                {
                    var parsedRoles = JsonSerializer.Deserialize<string[]>(roles.ToString());

                    foreach (var parsedRole in parsedRoles)
                    {
                        claims.Add(new Claim(ClaimTypes.Role, parsedRole));
                    }
                }
                else
                {
                    claims.Add(new Claim(ClaimTypes.Role, roles.ToString()));
                }

                keyValuePairs.Remove(ClaimTypes.Role);
            }

            claims.AddRange(keyValuePairs.Select(kvp => new Claim(kvp.Key, kvp.Value.ToString())));
            return claims;
        }

        private byte[] ParseBase64WithoutPadding(string base64)
        {
            switch (base64.Length % 4)
            {
                case 2: base64 += "=="; break;
                case 3: base64 += "="; break;
            }
            return Convert.FromBase64String(base64);
        }

        public async Task Login(string token)
        {
            await js.SetInLocalStorage(TOKENKEY, token);
            //var date = DateTime.UtcNow.AddMinutes(10).ToString();
            //await js.SetInCookie(TOKENKEY, token, date);

            var authState = BuildAuthenticationState(token);
            NotifyAuthenticationStateChanged(Task.FromResult(authState));
        }

        public async Task Logout()
        {
            await js.RemoveItem(TOKENKEY);
            await js.RemoveItem(EXPIRATION);
            _http.DefaultRequestHeaders.Authorization = null;
            NotifyAuthenticationStateChanged(Task.FromResult(anonimo));
            //await js.Reload();
        }

        public async Task Login(string token, DateTime expiration)
        {
            await js.SetInLocalStorage(TOKENKEY, token);
            await js.SetInLocalStorage("NOW", DateTime.Now.ToString());
            await js.SetInLocalStorage(EXPIRATION, expiration.ToString());
            //var date = DateTime.UtcNow.AddMinutes(10).ToString();
            //await js.SetInCookie(TOKENKEY, token, date);

            var authState = BuildAuthenticationState(token);
            NotifyAuthenticationStateChanged(Task.FromResult(authState));
        }

        public async Task<string> GetTokenAsync()
        {
            var expiration = await js.GetFromLocalStorage(EXPIRATION);
            if (expiration != null)
            {
                if (DateTime.Parse(expiration) > DateTime.Now)
                {
                    return await js.GetFromLocalStorage(TOKENKEY);
                }
                else
                {
                    await Logout();
                }
            }

            return null;
        }//GETTOKEN ASYNC
    }
}
