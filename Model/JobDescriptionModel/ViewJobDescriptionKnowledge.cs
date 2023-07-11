namespace HCMIS.Model.JobDescriptionModel
{
    public class ViewJobDescriptionKnowledge
    {
        public double KnowledgeId { get; set; }
        public int? JobDescriptionId { get; set; }
        public int? LevelofEducationId { get; set; }
        public string? LevelofEducationDesc { get; set; }
        public int? FieldofStudyId { get; set; }
        public string? FieldOfStudyDesc { get; set; }
        public bool IsRequired { get; set; }
        public string? Notes { get; set; }
    }
}
