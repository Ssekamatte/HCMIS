using HCMIS.Model;

namespace HCMIS.ViewModel
{
    public class AptituddeTestQuestionModel
    {
        public int AptituddeTestQuestionId { get; set; }
        public AptituddeTestQuestions? Aptituddetestquestions { get; set; }
        public List<AptituddeTestQuestionAnswers>? Aptituddetestquestionanswers { get; set; }
    }
}
