using HCMIS.SHARED.Models;

namespace HCMIS.DTOs
{
    public class AmptituddeTestDoneDto
    {
        public AptituddeTestDoneHeader? TestDoneHeader { get; set; }
        public List<AptituddeTestDoneAnswers>? TestDoneAnswers { get; set; }
    }
}
