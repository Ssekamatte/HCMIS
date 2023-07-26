using HCMIS.Data;
using HCMIS.Interface;
using HCMIS.SHARED;
using HCMIS.SHARED.Data;
using HCMIS.SHARED.Models.SPModel;

namespace HCMIS.Interface
{
    public interface IReportService
    {
        Task<List<spViewBalanceScoreCardReportResult>> GetAppraisal(UtilitiesSearchPanel SearchModel);
        Task<List<spViewEmployeeLeavesReportResult>> GetLeaveRequest(UtilitiesSearchPanel SearchModel);
        Task<List<EmployeeDto>> GetEmployeeDetails(UtilitiesSearchPanel SearchModel);
        Task<List<ViewEmployeeQualificationDto>> GetEmployeeQualifications(UtilitiesSearchPanel SearchModel);
        Task<List<ViewEmployeeFamilyDto>> GetEmployeeFamily(UtilitiesSearchPanel SearchModel);
    }
}
