using HCMIS.DTOs;
using HCMIS.SHARED.Models;
using HCMIS.ViewModel;

namespace HCMIS.Interface
{
    public interface IJobApplications
    {
        Task<List<AppliedForJobs>?> GetApplicationsAsync(string? ApplicationStatusId, string? MeetsRequirementsId, string? DepartmentId, string? ReferenceNumber);
        Task<List<AppliedForJobs>?> GetMyApplicationsAsync(string? ApplicationStatusId, string? ApplicantId);
        Task SaveUpdateApplicationAsync(AppliedForJobs data);
        Task<List<AppliedForJobs>?> InviteApplicantsAsync(List<AppliedForJobs> data);

    }
}
