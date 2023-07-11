namespace HCMIS.Model
{
    public class AptituddeTestQuestionAnswers
    {
        public int AptituddeTestQuestionAnswersId { get; set; }
        public int? AptituddeTestQuestionId { get; set; }
        public string? Answer { get; set; }
        public bool IsCorrectAnswer { get; set; }
    }
}
