using Blazor.SubtleCrypto;
using Blazored.LocalStorage;
using Blazored.Toast.Services;

using HCMIS.Interface;

using System.Net.Http.Headers;
using System.Text.Json;
using static System.Net.WebRequestMethods;

using HCMIS.SHARED;
using HCMIS.SHARED.Models;
using HCMIS.SHARED.Data;
using System.Net.Http.Json;
using System.Net.Http;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HCMIS.Repository
{
    public class UtilityRepository : IUtilityRepository
    {
        private readonly HttpClient _httpClient;
        private readonly JsonSerializerOptions _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        private readonly IToastService toastService;
        private readonly ICryptoService Crypto;
        private readonly ILocalStorageService LocalStorage;
        private readonly ISettingsRepository settingsRepo;

        public UtilityRepository(HttpClient httpClient, IToastService toastService
            , ICryptoService Crypto, ILocalStorageService LocalStorage, ISettingsRepository settingsRepo)
        {
             
            _httpClient = httpClient;
            this.toastService = toastService;
            this.Crypto = Crypto;
            this.LocalStorage = LocalStorage;
            this.settingsRepo = settingsRepo;
        }

        public async Task<List<ViewEmployeeDropDown>?> GetEmployees()
        {
            List<ViewEmployeeDropDown>? data = new List<ViewEmployeeDropDown>();
            try
            {
                var response = await _httpClient.GetAsync($"Utilities/GetEmployeeDD");
                var content = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    data = JsonSerializer.Deserialize<List<ViewEmployeeDropDown>>(content, _options);
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

        public async Task<List<Image>?> GetLocalLogos()
        {
            List<Image>? data = new List<Image>();
            try
            {
                var response = await _httpClient.GetAsync($"Utilities/GetLogos");
                var content = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    data = JsonSerializer.Deserialize<List<Image>>(content, _options);
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

        public async Task<AFieldOfStudy> AddFieldOfStudy(AFieldOfStudy data)
        {

            try
            {
                var val = (data);
                var response = await _httpClient.PostAsJsonAsync<AFieldOfStudy>("Utilities/CreateFieldOfStudy", data);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    data = JsonSerializer.Deserialize<AFieldOfStudy>(content, _options);
                }
                else
                {
                    toastService.ShowError(response.ReasonPhrase);
                }
            }
            catch (Exception ex)
            {
                toastService.ShowError(ex.Message.ToString());
            }
            return data;
        }

        public async Task<List<AFieldOfStudy>?> GetFieldOfStudy()
        {
            List<AFieldOfStudy>? data = new List<AFieldOfStudy>();
            try
            {
                var response = await _httpClient.GetAsync($"Utilities/GetFieldOfStudy");
                var content = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    data = JsonSerializer.Deserialize<List<AFieldOfStudy>>(content, _options);
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

    }
}
