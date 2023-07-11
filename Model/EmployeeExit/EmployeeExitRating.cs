using System;
using System.Collections.Generic;

namespace HCMIS.Model
{
    public partial class EmployeeExitRating
    {
        public int EmployeExitRatingId { get; set; }
        public int? ExitRatingAspectId { get; set; }
        public int? PoorExitRatingId { get; set; }
        public int? FairExitRatingId { get; set; }
        public int? GoodExitRatingId { get; set; }
        public int? VeryGoodExitRatingId { get; set; }
        public int? ExcellentExitRatingId { get; set; }
        public string? PoorRatingComments { get; set; }
        public bool? PoorRating { get; set; }
        public string? FairRatingComments { get; set; }
        public bool FairRating { get; set; }
        public string? GoodRatingComments { get; set; }
        public bool? GoodRating { get; set; }
        public string? VeryGoodRatingComments { get; set; }
        public bool? VeryGoodRating { get; set; }
        public string? ExecellentRatingComments { get; set; }
        public bool? ExecellentRating { get; set; }
        public int? ExitInterviewId { get; set; }
        public virtual EmployeeExitInterview? ExitInterview { get; set; }
        public virtual AExitRatingAspects? ExitRatingAspect { get; set; }
        public virtual AExitRating? FairExitRating { get; set; }
        public virtual AExitRating? GoodExitRating { get; set; }
        public virtual AExitRating? PoorExitRating { get; set; }
        public virtual AExitRating? VeryGoodExitRating { get; set; }
    }
}
