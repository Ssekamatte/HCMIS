using HCMIS.Model;

namespace HCMIS.ViewModel
{
    public class AppliedForSaveModel
    {
        public AppliedForJobs? appliedForJobs { get; set; }
        public List<AppliedForJobReferees>? appliedForJobReferees { get; set; }
    }
}
