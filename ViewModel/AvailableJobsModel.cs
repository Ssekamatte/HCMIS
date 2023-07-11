using HCMIS.Model;
using HCMIS.Model.JobDescriptionModel;

namespace HCMIS.ViewModel
{
    public class AvailableJobsModel
    {
        public ViewAvailableJobs? viewAvailableJobs { get; set; }
        public List<JobDescriptionWorkExperienceRequirement>? jobDescriptionWorkExperienceRequirement { get; set; }
        public List<JobDescriptionResponsibility>? jobDescriptionResponsibility { get; set; }
        public List<JobDescriptionBenefit>? jobDescriptionBenefit { get; set; }
        public List<ViewJobDescriptionKnowledge>? jobDescriptionKnowledge { get; set; }
    }
}
