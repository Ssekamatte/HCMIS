using HCMIS.SHARED.Models;

namespace HCMIS.Model.EmployeeExit
{
    public class EmployeeExitModel
    {
        public int ExitInterviewId { get; set; }
        public EmployeeExitInterview? EmployeeExitInterviewHeader { get; set; }
        public List<EmployeeExitRating>? EmployeeExitRatingHeader { get; set; }
    }
}
