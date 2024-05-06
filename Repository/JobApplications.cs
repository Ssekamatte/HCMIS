using Blazored.Toast.Services;
using HCMIS.DTOs;
using HCMIS.Interface;
using HCMIS.SHARED.Data;
using HCMIS.SHARED.Models;
using HCMIS.ViewModel;
using System.Net.Http.Headers;
using System.Text.Json;
using static SkiaSharp.HarfBuzz.SKShaper;

namespace HCMIS.Repository
{
    public class JobApplications : IJobApplications
    {
        private readonly HttpClient http;
        private readonly JsonSerializerOptions _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        private IToastService toastService;
        private readonly ISettingsRepository settingsRepo;
        public JobApplications(HttpClient http, IToastService toastService, ISettingsRepository settingsRepo)
        {
            this.http = http;
            this.toastService = toastService;
            this.settingsRepo = settingsRepo;
        }
        public async Task<List<AppliedForJobs>?> GetApplicationsAsync(string? ApplicationStatusId, string? MeetsRequirementsId, string? DepartmentId, string? ReferenceNumber)
        {
            List<AppliedForJobs> result = new List<AppliedForJobs>();
            try
            {
                string? accessToken = await settingsRepo.GetAccessToken();
                 
                var response = await http.GetAsync($"HumanResource/GetApplicationForStatus?ApplicationStatusId={ApplicationStatusId}&MeetsRequirementsId={MeetsRequirementsId}&DepartmentId={DepartmentId}&ReferenceNumber={ReferenceNumber}");
                var content = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    result = JsonSerializer.Deserialize<List<AppliedForJobs>>(content, _options);
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
            return result;
        }

        public async Task SaveUpdateApplicationAsync(AppliedForJobs data)
        {
            try
            {
                string? accessToken = await settingsRepo.GetAccessToken();
                 
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(data);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                var result = await http.PostAsync($"HumanResource/SaveJobApplication", httpContent);
                if (result.IsSuccessStatusCode)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    var _data = JsonSerializer.Deserialize<Response>(content, _options);
                    if (_data != null)
                    {
                        if (_data.IsSuccess)
                        {
                            toastService.ShowSuccess(_data.Message);
                        }
                        else
                        {
                            toastService.ShowError(_data.Message);
                        }
                    }
                }
                else
                {
                    toastService.ShowError(result.ReasonPhrase);
                }
            }
            catch (Exception ex)
            {
                toastService.ShowError(ex.Message);
            }
        }

        public async Task<List<AppliedForJobs>?> InviteApplicantsAsync(List<AppliedForJobs> data)
        {
            //List<AppliedForJobs> result = new List<AppliedForJobs>();
            try
            {
                string? accessToken = await settingsRepo.GetAccessToken();

                string json = Newtonsoft.Json.JsonConvert.SerializeObject(data);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                var result = await http.PostAsync($"HumanResource/InviteApplicants", httpContent);
                if (result.IsSuccessStatusCode)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    var _data = JsonSerializer.Deserialize<Response>(content, _options);
                    if (_data != null)
                    {
                        if (_data.IsSuccess)
                        {
                            toastService.ShowSuccess(_data.Message);
                        }
                        else
                        {
                            toastService.ShowError(_data.Message);
                        }
                    }
                }
                else
                {
                    toastService.ShowError(result.ReasonPhrase);
                }
            }
            catch (Exception ex)
            {
                toastService.ShowError(ex.Message);
            }

            return null;
        }

        public async Task<List<AppliedForJobs>?> GetMyApplicationsAsync(string? ApplicationStatusId, string? ApplicantId)
        {
            List<AppliedForJobs> result = new List<AppliedForJobs>();
            try
            {
                string? accessToken = await settingsRepo.GetAccessToken();
                 
                var response = await http.GetAsync($"HumanResource/GetMyApplications/{ApplicationStatusId}/{ApplicantId}");
                var content = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    result = JsonSerializer.Deserialize<List<AppliedForJobs>>(content, _options);
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
            return result;
        }
    }
}
