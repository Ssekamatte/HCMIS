using System;
using System.Collections.Generic;

namespace HCMIS.Models
{
    public partial class AptituddeTestDoneAnswers
    {
        public int TestDoneQuestionAnswersId { get; set; }
        public int? AptituddeTestDoneId { get; set; }
        public int? AptituddeTestQuestionId { get; set; }
        public int? AptituddeTestQuestionAnswersId { get; set; }
        public int? CorrectAnswerId { get; set; }
        public double? QuestionScore { get; set; }
        public double? AnswerScore { get; set; }
    }
}
