using HCMIS.Data;

using HCMIS.Model.EmployeeExit;
using HCMIS.ViewModel;
using Blazored.Toast.Services;
using System.Net.Http.Json;
using System.Net.Http;
using Microsoft.AspNetCore.Components.Routing;
using HCMIS.Model;

namespace HCMIS.Services
{
    public interface IExitInterviewService
    {
        Task<EmployeeExitModel> AddEmployeeExitModel(EmployeeExitModel employeeExitModel);
        Task<EmployeeExitModel> UpdateEmployeeExitModel(EmployeeExitModel employeeExitModel);
        Task<IEnumerable<EmployeeExitModel>> GetEmployeeExitList();
    }
    public class ExitInterviewService : IExitInterviewService
    {
        private readonly HttpClient _httpClient;
        private readonly IToastService _toast;
        ApiConfig _ApiConfig;
        public ExitInterviewService(HttpClient httpClient, IToastService toast, ApiConfig apiConfig)
        {
            this._httpClient = httpClient;
            this._toast = toast;
            _ApiConfig = apiConfig;
            _ApiConfig = apiConfig;

        }
        public async Task<EmployeeExitModel> AddEmployeeExitModel(EmployeeExitModel employeeExitModel)
        {
            try
            {
                var val = (employeeExitModel);
                var response = await _httpClient.PostAsJsonAsync<EmployeeExitModel>($"EmployeeLeave/AddRoster", employeeExitModel);
                if (response.IsSuccessStatusCode)
                {
                    _toast.ShowSuccess("Exit interview was sucessfully added");
                }
                else
                {
                    _toast.ShowError(response.ReasonPhrase);
                }
            }
            catch (Exception ex)
            {
                _toast.ShowError(ex.Message.ToString());
            }
            return employeeExitModel;
        }

        public Task<IEnumerable<EmployeeExitModel>> GetEmployeeExitList()
        {
            throw new NotImplementedException();
        }

        public Task<EmployeeExitModel> UpdateEmployeeExitModel(EmployeeExitModel employeeExitModel)
        {
            throw new NotImplementedException();
        }
    }
}
