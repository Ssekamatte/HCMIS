namespace HCMIS.Model
{
    public class AptituddeTestHeader
    {
        public int AptituddeTestHeaderId { get; set; }
        public int? DepartmentId { get; set; }
        public int? JobTitleId { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? CreatedBy { get; set; }
        public int? TestDuration { get; set; }
        public int? DurationTypeId { get; set; }
        public string? TestSummary { get; set; }
        public double? PassMark { get; set; }
        public double? NoOfQuestionsPerSession { get; set; }
    }
}
