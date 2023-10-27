using Blazor.SubtleCrypto;
using Blazored.LocalStorage;
using Blazored.Toast.Services;
using HCMIS.Data;
using HCMIS.Interface;
using HCMIS.Model;
using HCMIS.SHARED;
using HCMIS.SHARED.Data;
using HCMIS.SHARED.DTOs.BSC;
using HCMIS.SHARED.DTOs.Employeez;
using HCMIS.SHARED.Models.SPModel;
using System.Text.Json;
using static System.Net.WebRequestMethods;

namespace HCMIS.Repository
{
    public class ReportService : IReportService
    {
        private readonly HttpClient _httpClient;
        private readonly JsonSerializerOptions _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        private readonly IToastService toastService;
        private readonly ICryptoService Crypto;
        private readonly ILocalStorageService sessionStorage;
        public ReportService(HttpClient httpClient, IToastService toastService, ICryptoService Crypto, ILocalStorageService sessionStorage)
        {
            _httpClient = httpClient;
            this.toastService = toastService;
            this.Crypto = Crypto;
            this.sessionStorage = sessionStorage;
        }

        public async Task<List<ViewBalanceScoreCardReportDto>> GetAppraisal(UtilitiesSearchPanel SearchModel)
        {
            List<ViewBalanceScoreCardReportDto>? data = new List<ViewBalanceScoreCardReportDto>();
            try
            {
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(SearchModel);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                var result = await _httpClient.PostAsync($"Reports/GetAppraisalReport", httpContent);
                if (result.IsSuccessStatusCode)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    data = JsonSerializer.Deserialize<List<ViewBalanceScoreCardReportDto>>(content, _options);
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
            return data;
        }

        public async Task<List<ViewTargetSettingTotalsDto>> GetAppraisalTarget(UtilitiesSearchPanel SearchModel)
        {
            List<ViewTargetSettingTotalsDto>? data = new List<ViewTargetSettingTotalsDto>();
            try
            {
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(SearchModel);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                var result = await _httpClient.PostAsync($"Reports/GetAppraisalTarget", httpContent);
                if (result.IsSuccessStatusCode)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    data = JsonSerializer.Deserialize<List<ViewTargetSettingTotalsDto>>(content, _options);
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
            return data;
        }

        public async Task<List<ViewBehavioralTotalsDto>> GetAppraisalBehavioral(UtilitiesSearchPanel SearchModel)
        {
            List<ViewBehavioralTotalsDto>? data = new List<ViewBehavioralTotalsDto>();
            try
            {
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(SearchModel);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                var result = await _httpClient.PostAsync($"Reports/GetAppraisalBehavioral", httpContent);
                if (result.IsSuccessStatusCode)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    data = JsonSerializer.Deserialize<List<ViewBehavioralTotalsDto>>(content, _options);
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
            return data;
        }

        public async Task<List<BalanceScoreCardTargetSettingDto>> GetAppraisalTargetGeneral(UtilitiesSearchPanel SearchModel)
        {
            List<BalanceScoreCardTargetSettingDto>? data = new List<BalanceScoreCardTargetSettingDto>();
            try
            {
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(SearchModel);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                var result = await _httpClient.PostAsync($"Reports/GetAppraisalTargetGeneral", httpContent);
                if (result.IsSuccessStatusCode)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    data = JsonSerializer.Deserialize<List<BalanceScoreCardTargetSettingDto>>(content, _options);
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
            return data;
        }

        public async Task<List<BalanceScoreCardBehavioralDto>> GetAppraisalBehavioralGeneral(UtilitiesSearchPanel SearchModel)
        {
            List<BalanceScoreCardBehavioralDto>? data = new List<BalanceScoreCardBehavioralDto>();
            try
            {
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(SearchModel);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                var result = await _httpClient.PostAsync($"Reports/GetAppraisalBehavioralGeneral", httpContent);
                if (result.IsSuccessStatusCode)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    data = JsonSerializer.Deserialize<List<BalanceScoreCardBehavioralDto>>(content, _options);
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
            return data;
        }


        public async Task<List<spViewEmployeeLeavesReportResult>> GetLeaveRequest(UtilitiesSearchPanel SearchModel)
        {
            List<spViewEmployeeLeavesReportResult>? data = new List<spViewEmployeeLeavesReportResult>();
            try
            {
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(SearchModel);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                var result = await _httpClient.PostAsync($"Reports/GetLeaveRequestReport", httpContent);
                if (result.IsSuccessStatusCode)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    data = JsonSerializer.Deserialize<List<spViewEmployeeLeavesReportResult>>(content, _options);
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
            return data;
        }

        public async Task<List<EmployeeDto>> GetEmployeeDetails(UtilitiesSearchPanel SearchModel)
        {
            List<EmployeeDto>? data = new List<EmployeeDto>();
            try
            {
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(SearchModel);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                var result = await _httpClient.PostAsync($"Reports/GetEmployeeDetailsReport", httpContent);
                if (result.IsSuccessStatusCode)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    data = JsonSerializer.Deserialize<List<EmployeeDto>>(content, _options);
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
            return data;
        }

        public async Task<List<ViewEmployeeQualificationDto>> GetEmployeeQualifications(UtilitiesSearchPanel SearchModel)
        {
            List<ViewEmployeeQualificationDto>? data = new List<ViewEmployeeQualificationDto>();
            try
            {
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(SearchModel);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                var result = await _httpClient.PostAsync($"Reports/GetEmployeeQualificationsReport", httpContent);
                if (result.IsSuccessStatusCode)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    data = JsonSerializer.Deserialize<List<ViewEmployeeQualificationDto>>(content, _options);
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
            return data;
        }

        public async Task<List<ViewEmployeeFamilyDto>> GetEmployeeFamily(UtilitiesSearchPanel SearchModel)
        {
            List<ViewEmployeeFamilyDto>? data = new List<ViewEmployeeFamilyDto>();
            try
            {
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(SearchModel);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                var result = await _httpClient.PostAsync($"Reports/GetEmployeeFamilyReport", httpContent);
                if (result.IsSuccessStatusCode)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    data = JsonSerializer.Deserialize<List<ViewEmployeeFamilyDto>>(content, _options);
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
            return data;
        }

        public async Task<List<ViewEmployeeLeaveRoasterReportPivotedDto>> GetAnnualLeaveRoaster(UtilitiesSearchPanel SearchModel)
        {
            List<ViewEmployeeLeaveRoasterReportPivotedDto>? data = new List<ViewEmployeeLeaveRoasterReportPivotedDto>();
            try
            {
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(SearchModel);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                var result = await _httpClient.PostAsync($"Reports/GetAnnualLeaveRoasterReport", httpContent);
                if (result.IsSuccessStatusCode)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    data = JsonSerializer.Deserialize<List<ViewEmployeeLeaveRoasterReportPivotedDto>>(content, _options);
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
            return data;
        }

        public async Task<List<ViewEmployeeLeaveRoasterDatesReportDto>> GetSelectedDates(UtilitiesSearchPanel SearchModel)
        {
            List<ViewEmployeeLeaveRoasterDatesReportDto>? data = new List<ViewEmployeeLeaveRoasterDatesReportDto>();
            try
            {
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(SearchModel);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                var result = await _httpClient.PostAsync($"Reports/GetSelectedDates", httpContent);
                if (result.IsSuccessStatusCode)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    data = JsonSerializer.Deserialize<List<ViewEmployeeLeaveRoasterDatesReportDto>>(content, _options);
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
            return data;
        }

    }
}
