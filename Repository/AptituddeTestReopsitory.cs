using Blazored.Toast.Services;
using HCMIS.DTOs;
using HCMIS.Interface;
using HCMIS.SHARED.Data;
using HCMIS.ViewModel;
using System.Net.Http.Headers;
using System.Text.Json;
using static System.Net.WebRequestMethods;

namespace HCMIS.Repository
{
    public class AptituddeTestReopsitory : IAptituddeTestReopsitory
    {
        private readonly HttpClient http;
        private readonly ISettingsRepository settingsRepo;
        private IToastService toastService;
        private readonly JsonSerializerOptions _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        public AptituddeTestReopsitory(HttpClient http, ISettingsRepository settingsRepo, IToastService toastService)
        {
            this.http = http;
            this.settingsRepo = settingsRepo;
            this.toastService = toastService;
        }
        public async Task<List<AptituddeTestModel>?> GetAllAptituddeTests()
        {
            List<AptituddeTestModel>? data = new List<AptituddeTestModel>();
            string? accessToken = await settingsRepo.GetAccessToken();
             
            var response = await http.GetAsync($"HumanResource/GetAllAptituddeTests");
            var content = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                data = JsonSerializer.Deserialize<List<AptituddeTestModel>>(content, _options);
            }
            return data;
        }

        public async Task<AptituddeTestModel?> GetAplittuddeTestForJobTitleAsync(int JobTitleId)
        {
            AptituddeTestModel? data = new AptituddeTestModel();
            string? accessToken = await settingsRepo.GetAccessToken();
             
            var response = await http.GetAsync($"HumanResource/GetAptituddeTestsForJobTitle/{JobTitleId}");
            var content = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                data = JsonSerializer.Deserialize<AptituddeTestModel>(content, _options);
            }
            return data;
        }

        public async Task<List<AptituddeTestModel>?> GetAptituddeTestsForDepartment()
        {
            int departmentId = 1;
            List<AptituddeTestModel>? data = new List<AptituddeTestModel>();
            string? accessToken = await settingsRepo.GetAccessToken();
             
            var response = await http.GetAsync($"HumanResource/GetAptituddeTestsForDepartment/{departmentId}");
            var content = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                data = JsonSerializer.Deserialize<List<AptituddeTestModel>>(content, _options);
            }
            return data;
        }

        public async Task<HttpResponseMessage> SaveAptituddeTest(AptituddeTestModel model)
        {
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(model);
            StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            string? accessToken = await settingsRepo.GetAccessToken();
             
            var result = await http.PostAsync($"HumanResource/SaveAptituddeTest", httpContent);
            return result;
        }

        public async Task<AmptituddeTestDoneDto> SaveTestDone(AmptituddeTestDoneDto model)
        {
            AmptituddeTestDoneDto resultdata = new();
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(model);
            StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            string? accessToken = await settingsRepo.GetAccessToken();
             
            var result = await http.PostAsync($"HumanResource/SaveTestDone", httpContent);
            if (result.IsSuccessStatusCode)
            {
                var content = await result.Content.ReadAsStringAsync();
                resultdata = JsonSerializer.Deserialize<AmptituddeTestDoneDto>(content, _options);
            }
            else
            {
                var content = await result.Content.ReadAsStringAsync();
                var _data = JsonSerializer.Deserialize<Response>(content, _options);
                if(_data != null)
                {
                    toastService.ShowError(_data.Message);
                }
            }
            return resultdata;
        }
    }
}
