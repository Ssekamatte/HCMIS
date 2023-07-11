using HCMIS.DTOs;
using HCMIS.ViewModel;

namespace HCMIS.Interface
{
    public interface IJobApplications
    {
        Task<List<AppliedForJobDTO>?> GetApplicationsAsync(string? ApplicationStatusId);
        Task<List<AppliedForJobDTO>?> GetMyApplicationsAsync(string? ApplicationStatusId, string? ApplicantId);
        Task SaveUpdateApplicationAsync(AppliedForJobDTO data);
    }
}
