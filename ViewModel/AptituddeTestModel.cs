

using HCMIS.SHARED.Models;

namespace HCMIS.ViewModel
{
    public class AptituddeTestModel
    {
        public int AptituddeTestHeaderId { get; set; }
        public int? DepartmentId { get; set; }
        public int? JobTitleId { get; set; }
        public AptituddeTestHeader? Aptituddetestheader { get; set; }
        public List<AptituddeTestQuestionModel>? Aptituddetestquestions { get; set; }
    }
}
