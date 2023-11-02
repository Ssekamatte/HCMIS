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

        public async Task<List<Employee>?> GetEmployees()
        {
            List<Employee>? data = new List<Employee>();
            try
            {
                var response = await _httpClient.GetAsync($"Employeez/GetMasterList");
                var content = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    data = JsonSerializer.Deserialize<List<Employee>>(content, _options);
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

        public async Task GetLogos()
        {
            try
            {
                var response = await _httpClient.GetAsync($"Utilities/GetLogos");
                var content = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    var data = JsonSerializer.Deserialize<List<Image>>(content, _options);
                    if (data != null)
                    {
                        await LocalStorage.SetItemAsync("Logos", data);
                    }
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
        }

        public async Task<List<Image>> GetLocalLogos()
        {
            List<Image> data = new List<Image>();
            try
            {
                data = await LocalStorage.GetItemAsync<List<Image>>("Logos");
            }
            catch (Exception ex)
            {
                toastService.ShowError(ex.Message);
            }
            return data;
        }
    }
}
