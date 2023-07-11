using HCMIS.SHARED;
using System;
using System.Collections.Generic;

namespace HCMIS.Model
{
    public partial class EmployeeExitInterview
    {
        public EmployeeExitInterview()
        {
            EmployeeExitRating = new HashSet<EmployeeExitRating>();
            ExitClearanceCertificate = new HashSet<ExitClearanceCertificate>();
        }

        public int ExitInterviewId { get; set; }
        public int? EmployeeId { get; set; }
        public string? ReasonsForLeavingTheCompany { get; set; }
        public string? SatisfyingAboutYourJob { get; set; }
        public string? CompanyPoliciesMadeWorkDifficult { get; set; }
        public string? RecommendThisCompanyToAFriend { get; set; }
        public int? RecommendThisCompanyToAFriendYesNoid { get; set; }
        public int? CompanyPoliciesMadeWorkDifficultYesNoId { get; set; }
        public string? ChangesToMakeCompanyABetterPlaceToBe { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateToExit { get; set; }
        public double? OverallScore { get; set; }

        public virtual AYesNo? CompanyPoliciesMadeWorkDifficultYesNo { get; set; }
        public virtual EmployeeDto? Employee { get; set; }
        public virtual AYesNo? RecommendThisCompanyToAFriendYesNo { get; set; }
        public virtual ICollection<EmployeeExitRating> EmployeeExitRating { get; set; }
        public virtual ICollection<ExitClearanceCertificate> ExitClearanceCertificate { get; set; }
    }
}
