using System.Net.Http.Headers;
using System.Security.Claims;
using Blazor.SubtleCrypto;
using Blazored.LocalStorage;
using HCMIS.Features;
using HCMIS.Model;
using Microsoft.AspNetCore.Components.Authorization;

namespace HCMIS.AuthProviders
{
    public class HCMISAuthStateProvider : AuthenticationStateProvider
    {
        private readonly HttpClient _httpClient;
        private readonly ILocalStorageService _localStorage;
        private readonly ICryptoService Crypto;
        private readonly AuthenticationState _anonymous;
        public HCMISAuthStateProvider(HttpClient httpClient, ILocalStorageService localStorage, ICryptoService Crypto)
        {
            _httpClient = httpClient;
            _localStorage = localStorage;
            this.Crypto = Crypto;
        }
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var anonymous = new ClaimsIdentity();
            AuthenticationState m = new AuthenticationState(new ClaimsPrincipal(anonymous));
            try
            {
                var token = await _localStorage.GetItemAsync<LoginResultModel>("authToken");
                if (token != null)
                {
                    _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", token.token);
                    m= new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity(JwtParser.ParseClaimsFromJwt(token.token), "jwtAuthType")));
                }
            }
            catch (Exception ex)
            {

                //throw;
            }
            return m;
        }
        //public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        //{
        //    var _token = await _localStorage.GetItemAsync<string>("authToken");
        //    if (string.IsNullOrWhiteSpace(_token))
        //    {
        //        var anonymous = new ClaimsIdentity();
        //        return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal(anonymous)));
        //    }

        //    var token = await Crypto.DecryptAsync<LoginResultModel>(_token);
        //    if(token== null)
        //    {
        //        var anonymous = new ClaimsIdentity();
        //        return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal(anonymous)));
        //    }

        //    _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", token.token);
        //    return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity(JwtParser.ParseClaimsFromJwt(token.token), "jwtAuthType")));
        //}
        public void NotifyUserAuthentication(string token)
        {
            var authenticatedUser = new ClaimsPrincipal(new ClaimsIdentity(JwtParser.ParseClaimsFromJwt(token), "jwtAuthType"));
            var authState = Task.FromResult(new AuthenticationState(authenticatedUser));
            NotifyAuthenticationStateChanged(authState);
        }
        public void NotifyUserLogout()
        {
            // var authState = Task.FromResult(_anonymous);
            var anonymous = new ClaimsIdentity();
            var authState = Task.FromResult(new AuthenticationState(new ClaimsPrincipal(anonymous)));
            NotifyAuthenticationStateChanged(authState);
        }
    }
}
