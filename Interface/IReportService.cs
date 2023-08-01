using HCMIS.Data;
using HCMIS.Interface;
using HCMIS.SHARED;
using HCMIS.SHARED.Data;
using HCMIS.SHARED.DTOs.BSC;
using HCMIS.SHARED.Models.SPModel;
using Syncfusion.Blazor.DocumentEditor;

namespace HCMIS.Interface
{
    public interface IReportService
    {
        Task<List<BalanceScoreCardDto>> GetAppraisal(UtilitiesSearchPanel SearchModel);
        Task<List<spViewEmployeeLeavesReportResult>> GetLeaveRequest(UtilitiesSearchPanel SearchModel);
        Task<List<EmployeeDto>> GetEmployeeDetails(UtilitiesSearchPanel SearchModel);
        Task<List<ViewEmployeeQualificationDto>> GetEmployeeQualifications(UtilitiesSearchPanel SearchModel);
        Task<List<ViewEmployeeFamilyDto>> GetEmployeeFamily(UtilitiesSearchPanel SearchModel);
        Task<List<ViewBalanceScoreCardTargetSettingReportDto>> GetAppraisalTarget(UtilitiesSearchPanel SearchModel);
    }
}
