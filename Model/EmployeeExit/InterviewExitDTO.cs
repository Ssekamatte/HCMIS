using HCMIS.SHARED.Models;

namespace HCMIS.Model.EmployeeExit
{
    public class InterviewExitDTO
    {
        public int ExitInterviewId { get; set; }
        //public int? EmployeeId { get; set; }
        //public string? ReasonsForLeavingTheCompany { get; set; }
        //public string? SatisfyingAboutYourJob { get; set; }
        //public string? CompanyPoliciesMadeWorkDifficult { get; set; }
        //public string? RecommendThisCompanyToAFriend { get; set; }
        //public int? RecommendThisCompanyToAFriendYesNoid { get; set; }
        //public int? CompanyPoliciesMadeWorkDifficultYesNoId { get; set; }
        //public string? ChangesToMakeCompanyABetterPlaceToBe { get; set; }
        //public string? CreatedBy { get; set; }
        //public DateTime? DateCreated { get; set; }
        //public DateTime? DateToExit { get; set; }
        //public double? OverallScore { get; set; }
        public EmployeeExitInterview? EmployeeExitInterviewHeader { get; set; }
        public List<EmployeeExitRating>? EmployeeExitRatingHeader { get; set; }
        public List<spEmployeeExitInterviewResult>? InterviewRatingDetails { get; set; }
    }
}
