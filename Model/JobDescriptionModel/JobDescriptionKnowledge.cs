namespace HCMIS.Model.JobDescriptionModel
{
    public class JobDescriptionKnowledge
    {
        public double KnowledgeId { get; set; }
        /// <summary>
        /// This column will store the JobDescriptionId from the JobDescription that will be mapped to this specific work experience
        /// </summary>
        public int? JobDescriptionId { get; set; }
        public int? LevelofEducationId { get; set; }
        public int? FieldofStudyId { get; set; }
        public bool IsRequired { get; set; }
        /// <summary>
        /// This will Store the description of each Skill or Knowledge
        /// </summary>
        public string? Notes { get; set; }
        public string? AddedBy { get; set; }
        public DateTime? AddedDate { get; set; }
    }
}
