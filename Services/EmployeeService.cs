﻿using Blazored.Toast.Services;
using HCMIS.Data;
using HCMIS.Model;
using HCMIS.SHARED.Models;
using System.Net.Http;
using System.Net.Http.Json;

namespace HCMIS.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<ViewEmployeeMasterDetails>> GetEmployeeList();
        //Task<IEnumerable<ViewDisplinaryMasterDetails>> GetDisplinaryList();
        //Task<IEnumerable<ViewQualificationMasterDetails>> GetQualificationList();
        Task<IEnumerable<ViewLeaveMasterDetails>> GetLeaveList();
    }
    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient _httpClient;
        private readonly IToastService _toast;
        ApiConfig _ApiConfig;
        public EmployeeService(HttpClient httpClient, IToastService toast, ApiConfig apiConfig)
        {
            this._httpClient = httpClient;
            this._toast = toast;
            _ApiConfig = apiConfig;
        }
        public async Task<IEnumerable<ViewEmployeeMasterDetails>> GetEmployeeList()
        {
            //($"Employeez/GetEmployeeList");
            return await _httpClient.GetFromJsonAsync<IEnumerable<ViewEmployeeMasterDetails>>($"Employeez/GetMasterList");
        }

        //public async Task<IEnumerable<ViewDisplinaryMasterDetails>> GetDisplinaryList()
        //{
 
        //    return await _httpClient.GetFromJsonAsync<IEnumerable<ViewDisplinaryMasterDetails>>($"Employeez/GetDisplinaryMasterList");
        //}
        public async   Task<IEnumerable<ViewLeaveMasterDetails>> GetLeaveList()
        {

            return await _httpClient.GetFromJsonAsync<IEnumerable<ViewLeaveMasterDetails>>($"Employeez/GetLeaveMasterList");
        }
        //public async Task<IEnumerable<ViewQualificationMasterDetails>> GetQualificationList()
        //{

        //    return await _httpClient.GetFromJsonAsync<IEnumerable<ViewQualificationMasterDetails>>($"Employeez/GetQualificationMasterList");
        //}
    }
}
