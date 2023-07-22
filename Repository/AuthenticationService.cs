using Blazor.SubtleCrypto;
using Blazored.LocalStorage;
using Blazored.Toast.Services;
using HCMIS.AuthProviders;
using HCMIS.DTOs;
using HCMIS.Interface;
using HCMIS.Model;
using HCMIS.SHARED.Models.Usermanagement;
using Microsoft.AspNetCore.Components.Authorization;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Text.Json;
using HCMIS.SHARED.DTOs;
using HCMIS.SHARED.Models;

namespace HCMIS.Repository
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly HttpClient _client;
        private readonly JsonSerializerOptions _options;
        private readonly AuthenticationStateProvider _authStateProvider;
        private readonly ILocalStorageService _localStorage;
        private readonly ICryptoService Crypto;
        private readonly IToastService toastService;

        public AuthenticationService(HttpClient client, AuthenticationStateProvider authStateProvider, ILocalStorageService localStorage
            , ICryptoService Crypto, IToastService toastService)
        {
            _client = client;
            _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            _authStateProvider = authStateProvider;
            _localStorage = localStorage;
            this.Crypto = Crypto;
            this.toastService = toastService;
        }

        public async Task<bool> CheckAuthenticationStatus()
        {
            var result = await _localStorage.GetItemAsync<LoginResultModel>("authToken");
            if (result==null) return false;

            if ((result.expiration <= DateTime.Now) || string.IsNullOrEmpty(result.token))
            {
                await Logout();
                return false;
            }
            return true;
        }
        //public async Task<bool> CheckAuthenticationStatus()
        //{
        //    var result = await _localStorage.GetItemAsync<string>("authToken");
        //    if(string.IsNullOrWhiteSpace(result)) return false;

        //    var _result = await Crypto.DecryptAsync<LoginResultModel>(result);
        //    if (_result == null)
        //    {
        //        await Logout();
        //        return false;
        //    }
        //    if((_result.expiration <= DateTime.Now) || string.IsNullOrEmpty(_result.token))
        //    {
        //        await Logout();
        //        return false;
        //    }
        //    return true;
        //}
        public async Task<LoginResultModel> GetUserCredentials()
        {
            LoginResultModel model = new LoginResultModel();
            try
            {
                var result = await _localStorage.GetItemAsync<LoginResultModel>("authToken");
                if (result != null)
                {
                    model = result;
                }
            }
            catch (Exception ex)
            {
                toastService.ShowError(ex.Message);
            }
            return model;
        }
        //public async Task<LoginResultModel> GetUserCredentials()
        //{
        //    LoginResultModel model = new LoginResultModel();
        //    try
        //    {
        //        var result = await _localStorage.GetItemAsync<string>("authToken");
        //        if (!string.IsNullOrWhiteSpace(result))
        //        {
        //            model = await Crypto.DecryptAsync<LoginResultModel>(result);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        toastService.ShowError(ex.Message);
        //    }
        //    return model;
        //}
        public async Task<LoginResultModel> Login(LoginModel userForAuthentication)
        {
            LoginResultModel result = new LoginResultModel();
            try
            {
                var content = JsonSerializer.Serialize(userForAuthentication);
                var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");

                var authResult = await _client.PostAsync("Account/login", bodyContent);
                
                if (!authResult.IsSuccessStatusCode)
                {
                    toastService.ShowWarning(authResult.ReasonPhrase);
                    return result;
                }

                var authContent = await authResult.Content.ReadAsStringAsync();
                result = JsonSerializer.Deserialize<LoginResultModel>(authContent, _options);
                if (result!=null) 
                {
                    if (result.IsSuccess==false)
                    {
                        toastService.ShowWarning(result.ErrorMsg);
                    }
                    else
                    {
                        await _localStorage.SetItemAsync("authToken", result);
                        _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", result.token);
                        ((HCMISAuthStateProvider)_authStateProvider).NotifyUserAuthentication(result.token);
                        
                    }
                }
                //var _outhtoken = await Crypto.EncryptAsync(result);

                
            }
            catch (Exception ex)
            {
                //toastService.ShowError(ex.Message);
                toastService.ShowError(ex.ToString());
            }


            return result;
        }
        //public async Task<LoginResultModel> Login(LoginModel userForAuthentication)
        //{
        //    LoginResultModel result = new LoginResultModel();
        //    try
        //    {
        //        var content = JsonSerializer.Serialize(userForAuthentication);
        //        var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");

        //        var authResult = await _client.PostAsync("Account/login", bodyContent);
        //        var authContent = await authResult.Content.ReadAsStringAsync();
        //        result = JsonSerializer.Deserialize<LoginResultModel>(authContent, _options);

        //        if (!authResult.IsSuccessStatusCode)
        //            return result;

        //        var _outhtoken = await Crypto.EncryptAsync(result);

        //        await _localStorage.SetItemAsync("authToken", _outhtoken.Value);
        //        ((HCMISAuthStateProvider)_authStateProvider).NotifyUserAuthentication(result.token);
        //        _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", result.token);
        //    }
        //    catch (Exception ex)
        //    {
        //        //toastService.ShowError(ex.Message);
        //        toastService.ShowError(ex.ToString());
        //    }


        //    return result;
        //}

        public async Task Logout()
        {
            await _localStorage.RemoveItemAsync("authToken");
            ((HCMISAuthStateProvider)_authStateProvider).NotifyUserLogout();
            _client.DefaultRequestHeaders.Authorization = null;
        }

        public async Task<ResponseDto> RegisterUser(RegisterModel userForRegistration)
        {
            ResponseDto data = new ResponseDto();
            try
            {
                var content = JsonSerializer.Serialize(userForRegistration);
                var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");

                var authResult = await _client.PostAsync("Account/register", bodyContent);
                var authContent = await authResult.Content.ReadAsStringAsync();
                var result = JsonSerializer.Deserialize<ResponseDto>(authContent, _options);

                if (!authResult.IsSuccessStatusCode)
                {
                    toastService.ShowError(authResult.ReasonPhrase);
                }
                else
                {
                    data = result;
                }
            }
            catch (Exception ex)
            {
                toastService.ShowError(ex.Message);
            }
            return data;
        }

        // Generate a random number between two numbers    
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        // Generate a random Character    
        public char RandomCharacter()
        {
            String sc = "!@#$%^&*~";
            Random random = new Random();
            int sz = random.Next(sc.Length);
            return sc.ElementAt(sz);
        }

        // Generate a random string with a given size and case.   
        // If second parameter is true, the return string is lowercase  
        public string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }

        // Generate a random password of a given length (optional)  
        public string RandomPassword(int size = 0)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4, true));
            builder.Append(RandomNumber(1000, 9999));
            builder.Append(RandomCharacter());
            builder.Append(RandomString(2, false));
            return builder.ToString();
        }

        public async Task<List<AspNetRoles>> GetUserRoles()
        {
            List < AspNetRoles > data = new List <AspNetRoles>();
            try
            {
                var response = await _client.GetAsync($"Account/GetSystemRoles");
                var content = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    data = JsonSerializer.Deserialize<List<AspNetRoles>>(content, _options);
                    
                }
                else
                {
                    toastService.ShowError(response.ReasonPhrase);
                }
            }
            catch (Exception ex)
            {
                toastService.ShowError(ex.Message);
            }
            return data;
        }

        public async Task<List<ViewUserManagement>> GetSystemUsers()
        {
            List<ViewUserManagement> data = new List<ViewUserManagement>();
            try
            {
                var response = await _client.GetAsync($"Account/GetSystemUsers");
                var content = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    data = JsonSerializer.Deserialize<List<ViewUserManagement>>(content, _options);

                }
                else
                {
                    toastService.ShowError(response.ReasonPhrase);
                }
            }
            catch (Exception ex)
            {
                toastService.ShowError(ex.Message);
            }
            return data;
        }

        public async Task ChangeUserPassword(ChangePasswordModel model)
        {
            try
            {
                var content = JsonSerializer.Serialize(model);
                var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");

                var authResult = await _client.PostAsync("Account/ChangeUserPassword", bodyContent);
                var authContent = await authResult.Content.ReadAsStringAsync();

                if (!authResult.IsSuccessStatusCode)
                {
                    toastService.ShowError(authResult.ReasonPhrase);
                }
                else
                {
                    var m = JsonSerializer.Deserialize<ResponseDto>(authContent, _options);
                    if(m!= null)
                    {
                        if (m.IsSuccess == true)
                        {
                            toastService.ShowSuccess(m.Message);
                        }
                        else
                        {
                            toastService.ShowError(m.Message);
                        }
                    }
                    
                }
            }
            catch (Exception ex)
            {
                toastService.ShowError(ex.Message);
            }
        }

        public async Task ChangePassword(ChangePasswordViewModel model)
        {
            try
            {
                var content = JsonSerializer.Serialize(model);
                var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");

                var authResult = await _client.PostAsync("Account/ChangePassword", bodyContent);
                var authContent = await authResult.Content.ReadAsStringAsync();

                if (!authResult.IsSuccessStatusCode)
                {
                    toastService.ShowError(authResult.ReasonPhrase);
                }
                else
                {
                    var m = JsonSerializer.Deserialize<ResponseDto>(authContent, _options);
                    if (m != null)
                    {
                        if (m.IsSuccess == true)
                        {
                            toastService.ShowSuccess(m.Message);
                        }
                        else
                        {
                            toastService.ShowError(m.Message);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                toastService.ShowError(ex.Message);
            }
        }

        public async Task InitialisePasswordReset(ResetPasswordDTO data)
        {
            try
            {
                var content = JsonSerializer.Serialize(data);
                var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");

                var authResult = await _client.PostAsync("Account/InitialisePasswordReset", bodyContent);
                var authContent = await authResult.Content.ReadAsStringAsync();

                if (!authResult.IsSuccessStatusCode)
                {
                    toastService.ShowError(authResult.ReasonPhrase);
                }
                else
                {
                    var m = JsonSerializer.Deserialize<ResponseDto>(authContent, _options);
                    if (m != null)
                    {
                        if (m.IsSuccess == true)
                        {
                            toastService.ShowSuccess(m.Message);
                        }
                        else
                        {
                            toastService.ShowError(m.Message);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                toastService.ShowError(ex.Message);
            }
        }

        public async Task UpdateAccountInformation(ViewUserManagement data)
        {
            try
            {
                var content = JsonSerializer.Serialize(data);
                var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");

                var authResult = await _client.PostAsync("Account/UpdateAccountInformation", bodyContent);
                var authContent = await authResult.Content.ReadAsStringAsync();

                if (!authResult.IsSuccessStatusCode)
                {
                    toastService.ShowError(authResult.ReasonPhrase);
                }
                else
                {
                    var m = JsonSerializer.Deserialize<ResponseDto>(authContent, _options);
                    if (m != null)
                    {
                        if (m.IsSuccess == true)
                        {
                            toastService.ShowSuccess(m.Message);
                        }
                        else
                        {
                            toastService.ShowError(m.Message);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                toastService.ShowError(ex.Message);
            }
        }
    }
}
