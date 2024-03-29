﻿
using HCMIS.SHARED;
using HCMIS.SHARED.Data;
using HCMIS.SHARED.Models;

namespace HCMIS.Interface
{
    public interface IUtilityRepository
    {
        Task<List<ViewEmployeeDropDown>?> GetEmployees();
        Task<List<Image>> GetLocalLogos();
        Task<AFieldOfStudy> AddFieldOfStudy(AFieldOfStudy data);

        Task<List<AFieldOfStudy>?> GetFieldOfStudy();
    }
}
