

using HCMIS.SHARED.Models;

namespace HCMIS.ViewModel
{
    public class JobApplicationsModel
    {
        public int AppliedForJobsId { get; set; }
        public ViewAppliedForJobs? viewAppliedForJobs { get; set; }
        public List<NonStaffLanguagesKnown>? LanguagesKnown { get; set; }
        public List<NonStaffQualification>? Qualification { get; set; }
        public List<NonStaffWorkExperience>? WorkExperience { get; set; }
        public List<NonStaffSkills>? Skills { get; set; }
    }
}
