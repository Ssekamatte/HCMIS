using HCMIS.Data;
using HCMIS.Interface;
using HCMIS.SHARED;
using HCMIS.SHARED.Data;
using HCMIS.SHARED.Models;
using Syncfusion.Blazor.DocumentEditor;

namespace HCMIS.Interface
{
    public interface IReportService
    {
        Task<List<ViewBalanceScoreCardReport>> GetAppraisal(UtilitiesSearchPanel SearchModel);
        Task<List<Employee>> GetEmployeeDetails(UtilitiesSearchPanel SearchModel);
        Task<List<ViewEmployeeQualification>> GetEmployeeQualifications(UtilitiesSearchPanel SearchModel);
        Task<List<ViewEmployeeFamily>> GetEmployeeFamily(UtilitiesSearchPanel SearchModel);
        Task<List<ViewTargetSettingTotals>> GetAppraisalTarget(UtilitiesSearchPanel SearchModel);
        Task<List<ViewBehavioralTotals>> GetAppraisalBehavioral(UtilitiesSearchPanel SearchModel);
        Task<List<ViewEmployeeLeaveRoasterReportPivoted>> GetAnnualLeaveRoaster(UtilitiesSearchPanel SearchModel);
        Task<List<EmployeeLeaveRoster>> GetAnnualLeaveRoasterMonthDays(UtilitiesSearchPanel SearchModel);
        Task<List<EmployeeLeaveRoster>> GetSelectedDates(UtilitiesSearchPanel SearchModel);
        Task<List<BalanceScoreCardTargetSetting>> GetAppraisalTargetGeneral(UtilitiesSearchPanel SearchModel);
        Task<List<BalanceScoreCardBehavioral>> GetAppraisalBehavioralGeneral(UtilitiesSearchPanel SearchModel);
        Task<List<BalanceScoreCardTargetDevelopmentPlan>> GetDevelopmentPlan(UtilitiesSearchPanel SearchModel);
        Task<List<BalanceScoreCardAppraiseeComments>> GetAppraiseeComments(UtilitiesSearchPanel SearchModel);
        Task<List<BalanceScoreCardSupervisorComments>> GetSupervisorComments(UtilitiesSearchPanel SearchModel);
        Task<List<BalanceScoreCardHodcomments>> GetHODComments(UtilitiesSearchPanel SearchModel);
        Task<List<BalanceScoreCardCeocomments>> GetCEOComments(UtilitiesSearchPanel SearchModel);
        Task<List<ViewEmployeeLeaveReport>> GetLeaveRequest(UtilitiesSearchPanel SearchModel);
        Task<List<ViewTimeandAttendance>> GetBiometricRawData(UtilitiesSearchPanel SearchModel);
        Task<List<ViewTimeandAttendanceSummary>> GetAttendanceData(UtilitiesSearchPanel SearchModel);
    }
}
