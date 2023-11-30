using Blazor.SubtleCrypto;
using Blazored.LocalStorage;
using Blazored.Toast.Services;
using HCMIS.Data;
using HCMIS.Interface;

using HCMIS.SHARED;
using HCMIS.SHARED.Data;
using HCMIS.SHARED.Models;
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

        #region Appraisal
        public async Task<List<ViewBalanceScoreCardReport>> GetAppraisal(UtilitiesSearchPanel SearchModel)
        {
            List<ViewBalanceScoreCardReport>? data = new List<ViewBalanceScoreCardReport>();
            try
            {
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(SearchModel);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                var result = await _httpClient.PostAsync($"Reports/GetAppraisalReport", httpContent);
                if (result.IsSuccessStatusCode)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    data = JsonSerializer.Deserialize<List<ViewBalanceScoreCardReport>>(content, _options);
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

        public async Task<List<ViewTargetSettingTotals>> GetAppraisalTarget(UtilitiesSearchPanel SearchModel)
        {
            List<ViewTargetSettingTotals>? data = new List<ViewTargetSettingTotals>();
            try
            {
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(SearchModel);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                var result = await _httpClient.PostAsync($"Reports/GetAppraisalTarget", httpContent);
                if (result.IsSuccessStatusCode)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    data = JsonSerializer.Deserialize<List<ViewTargetSettingTotals>>(content, _options);
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

        public async Task<List<ViewBehavioralTotals>> GetAppraisalBehavioral(UtilitiesSearchPanel SearchModel)
        {
            List<ViewBehavioralTotals>? data = new List<ViewBehavioralTotals>();
            try
            {
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(SearchModel);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                var result = await _httpClient.PostAsync($"Reports/GetAppraisalBehavioral", httpContent);
                if (result.IsSuccessStatusCode)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    data = JsonSerializer.Deserialize<List<ViewBehavioralTotals>>(content, _options);
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

        public async Task<List<BalanceScoreCardTargetSetting>> GetAppraisalTargetGeneral(UtilitiesSearchPanel SearchModel)
        {
            List<BalanceScoreCardTargetSetting>? data = new List<BalanceScoreCardTargetSetting>();
            try
            {
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(SearchModel);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                var result = await _httpClient.PostAsync($"Reports/GetAppraisalTargetGeneral", httpContent);
                if (result.IsSuccessStatusCode)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    data = JsonSerializer.Deserialize<List<BalanceScoreCardTargetSetting>>(content, _options);
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

        public async Task<List<BalanceScoreCardBehavioral>> GetAppraisalBehavioralGeneral(UtilitiesSearchPanel SearchModel)
        {
            List<BalanceScoreCardBehavioral>? data = new List<BalanceScoreCardBehavioral>();
            try
            {
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(SearchModel);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                var result = await _httpClient.PostAsync($"Reports/GetAppraisalBehavioralGeneral", httpContent);
                if (result.IsSuccessStatusCode)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    data = JsonSerializer.Deserialize<List<BalanceScoreCardBehavioral>>(content, _options);
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

        public async Task<List<BalanceScoreCardTargetDevelopmentPlan>> GetDevelopmentPlan(UtilitiesSearchPanel SearchModel)
        {
            List<BalanceScoreCardTargetDevelopmentPlan>? data = new List<BalanceScoreCardTargetDevelopmentPlan>();
            try
            {
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(SearchModel);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                var result = await _httpClient.PostAsync($"Reports/GetDevelopmentPlan", httpContent);
                if (result.IsSuccessStatusCode)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    data = JsonSerializer.Deserialize<List<BalanceScoreCardTargetDevelopmentPlan>>(content, _options);
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

        public async Task<List<BalanceScoreCardAppraiseeComments>> GetAppraiseeComments(UtilitiesSearchPanel SearchModel)
        {
            List<BalanceScoreCardAppraiseeComments>? data = new List<BalanceScoreCardAppraiseeComments>();
            try
            {
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(SearchModel);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                var result = await _httpClient.PostAsync($"Reports/GetAppraiseeComments", httpContent);
                if (result.IsSuccessStatusCode)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    data = JsonSerializer.Deserialize<List<BalanceScoreCardAppraiseeComments>>(content, _options);
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

        public async Task<List<BalanceScoreCardSupervisorComments>> GetSupervisorComments(UtilitiesSearchPanel SearchModel)
        {
            List<BalanceScoreCardSupervisorComments>? data = new List<BalanceScoreCardSupervisorComments>();
            try
            {
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(SearchModel);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                var result = await _httpClient.PostAsync($"Reports/GetSupervisorComments", httpContent);
                if (result.IsSuccessStatusCode)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    data = JsonSerializer.Deserialize<List<BalanceScoreCardSupervisorComments>>(content, _options);
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

        public async Task<List<BalanceScoreCardHodcomments>> GetHODComments(UtilitiesSearchPanel SearchModel)
        {
            List<BalanceScoreCardHodcomments>? data = new List<BalanceScoreCardHodcomments>();
            try
            {
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(SearchModel);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                var result = await _httpClient.PostAsync($"Reports/GetHODComments", httpContent);
                if (result.IsSuccessStatusCode)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    data = JsonSerializer.Deserialize<List<BalanceScoreCardHodcomments>>(content, _options);
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

        public async Task<List<BalanceScoreCardCeocomments>> GetCEOComments(UtilitiesSearchPanel SearchModel)
        {
            List<BalanceScoreCardCeocomments>? data = new List<BalanceScoreCardCeocomments>();
            try
            {
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(SearchModel);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                var result = await _httpClient.PostAsync($"Reports/GetCEOComments", httpContent);
                if (result.IsSuccessStatusCode)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    data = JsonSerializer.Deserialize<List<BalanceScoreCardCeocomments>>(content, _options);
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


        #endregion Appraisal

        #region Leave
        public async Task<List<ViewEmployeeLeaveReport>> GetLeaveRequest(UtilitiesSearchPanel SearchModel)
        {
            List<ViewEmployeeLeaveReport>? data = new List<ViewEmployeeLeaveReport>();
            try
            {
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(SearchModel);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                var result = await _httpClient.PostAsync($"Reports/GetLeaveRequestReport", httpContent);
                if (result.IsSuccessStatusCode)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    data = JsonSerializer.Deserialize<List<ViewEmployeeLeaveReport>>(content, _options);
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

        #endregion Leave


        public async Task<List<Employee>> GetEmployeeDetails(UtilitiesSearchPanel SearchModel)
        {
            List<Employee>? data = new List<Employee>();
            try
            {
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(SearchModel);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                var result = await _httpClient.PostAsync($"Reports/GetEmployeeDetailsReport", httpContent);
                if (result.IsSuccessStatusCode)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    data = JsonSerializer.Deserialize<List<Employee>>(content, _options);
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

        public async Task<List<ViewEmployeeQualification>> GetEmployeeQualifications(UtilitiesSearchPanel SearchModel)
        {
            List<ViewEmployeeQualification>? data = new List<ViewEmployeeQualification>();
            try
            {
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(SearchModel);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                var result = await _httpClient.PostAsync($"Reports/GetEmployeeQualificationsReport", httpContent);
                if (result.IsSuccessStatusCode)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    data = JsonSerializer.Deserialize<List<ViewEmployeeQualification>>(content, _options);
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

        public async Task<List<ViewEmployeeFamily>> GetEmployeeFamily(UtilitiesSearchPanel SearchModel)
        {
            List<ViewEmployeeFamily>? data = new List<ViewEmployeeFamily>();
            try
            {
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(SearchModel);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                var result = await _httpClient.PostAsync($"Reports/GetEmployeeFamilyReport", httpContent);
                if (result.IsSuccessStatusCode)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    data = JsonSerializer.Deserialize<List<ViewEmployeeFamily>>(content, _options);
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

        public async Task<List<ViewEmployeeLeaveRoasterReportPivotedNew>> GetAnnualLeaveRoaster(UtilitiesSearchPanel SearchModel)
        {
            List<ViewEmployeeLeaveRoasterReportPivotedNew>? data = new List<ViewEmployeeLeaveRoasterReportPivotedNew>();
            try
            {
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(SearchModel);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                var result = await _httpClient.PostAsync($"Reports/GetAnnualLeaveRoasterReport", httpContent);
                if (result.IsSuccessStatusCode)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    data = JsonSerializer.Deserialize<List<ViewEmployeeLeaveRoasterReportPivotedNew>>(content, _options);
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

        public async Task<List<ViewEmployeeLeaveRoasterReportNew>> GetAnnualLeaveRoasterMonthDays(UtilitiesSearchPanel SearchModel)
        {
            List<ViewEmployeeLeaveRoasterReportNew>? data = new List<ViewEmployeeLeaveRoasterReportNew>();
            try
            {
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(SearchModel);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                var result = await _httpClient.PostAsync($"Reports/GetAnnualLeaveRoasterMonthDays", httpContent);
                if (result.IsSuccessStatusCode)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    data = JsonSerializer.Deserialize<List<ViewEmployeeLeaveRoasterReportNew>>(content, _options);
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


        public async Task<List<EmployeeLeaveRoster>> GetSelectedDates(UtilitiesSearchPanel SearchModel)
        {
            List<EmployeeLeaveRoster>? data = new List<EmployeeLeaveRoster>();
            try
            {
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(SearchModel);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                var result = await _httpClient.PostAsync($"Reports/GetSelectedDates", httpContent);
                if (result.IsSuccessStatusCode)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    data = JsonSerializer.Deserialize<List<EmployeeLeaveRoster>>(content, _options);
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
