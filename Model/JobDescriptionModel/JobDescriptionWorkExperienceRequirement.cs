namespace HCMIS.Model.JobDescriptionModel
{
    public class JobDescriptionWorkExperienceRequirement
    {
        public double ExperienceId { get; set; }
        /// <summary>
        /// This column will store the JobDescriptionId from the JobDescription that will be mapped to this specific work experience
        /// </summary>
        public int? JobDescriptionId { get; set; }
        /// <summary>
        /// This will Store the description of each Experience
        /// </summary>
        public string? ExperienceDesc { get; set; }
        public string? AddedBy { get; set; }
        public DateTime? AddedDate { get; set; }
    }
}
