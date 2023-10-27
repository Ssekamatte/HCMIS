using HCMIS.Data;
using HCMIS.Interface;
using HCMIS.SHARED;
using HCMIS.SHARED.Data;
using HCMIS.SHARED.DTOs.BSC;
using HCMIS.SHARED.DTOs.Employeez;
using HCMIS.SHARED.Models.SPModel;
using Syncfusion.Blazor.DocumentEditor;

namespace HCMIS.Interface
{
    public interface IReportService
    {
        Task<List<ViewBalanceScoreCardReportDto>> GetAppraisal(UtilitiesSearchPanel SearchModel);
        Task<List<spViewEmployeeLeavesReportResult>> GetLeaveRequest(UtilitiesSearchPanel SearchModel);
        Task<List<EmployeeDto>> GetEmployeeDetails(UtilitiesSearchPanel SearchModel);
        Task<List<ViewEmployeeQualificationDto>> GetEmployeeQualifications(UtilitiesSearchPanel SearchModel);
        Task<List<ViewEmployeeFamilyDto>> GetEmployeeFamily(UtilitiesSearchPanel SearchModel);
        Task<List<ViewTargetSettingTotalsDto>> GetAppraisalTarget(UtilitiesSearchPanel SearchModel);
        Task<List<ViewBehavioralTotalsDto>> GetAppraisalBehavioral(UtilitiesSearchPanel SearchModel);
        Task<List<ViewEmployeeLeaveRoasterReportPivotedDto>> GetAnnualLeaveRoaster(UtilitiesSearchPanel SearchModel);
        Task<List<ViewEmployeeLeaveRoasterDatesReportDto>> GetSelectedDates(UtilitiesSearchPanel SearchModel);
        Task<List<BalanceScoreCardTargetSettingDto>> GetAppraisalTargetGeneral(UtilitiesSearchPanel SearchModel);
        Task<List<BalanceScoreCardBehavioralDto>> GetAppraisalBehavioralGeneral(UtilitiesSearchPanel SearchModel);
    }
}
