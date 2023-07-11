namespace HCMIS.Model
{
    public class AptituddeTestQuestions
    {
        public int AptituddeTestQuestionId { get; set; }
        public int? AptituddeTestHeaderId { get; set; }
        public int? DifficultyLevelId { get; set; }
        public string? Question { get; set; }
        public string? QuestionImageName { get; set; }
        public string? QuestionImageExt { get; set; }
        public bool IsAmultiselectQuestion { get; set; }
        public double? QuestionMark { get; set; }
    }
}
