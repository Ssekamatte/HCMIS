using System;
using System.Collections.Generic;

namespace HCMIS.Model
{
    public partial class AExitRating
    {
        public AExitRating()
        {
            EmployeeExitRatingFairExitRating = new HashSet<EmployeeExitRating>();
            EmployeeExitRatingGoodExitRating = new HashSet<EmployeeExitRating>();
            EmployeeExitRatingPoorExitRating = new HashSet<EmployeeExitRating>();
            EmployeeExitRatingVeryGoodExitRating = new HashSet<EmployeeExitRating>();
        }

        public int ExitRatingId { get; set; }
        public string? RatingDescription { get; set; }
        public double? RatingValue { get; set; }
        public double? RatingScore { get; set; }

        public virtual ICollection<EmployeeExitRating> EmployeeExitRatingFairExitRating { get; set; }
        public virtual ICollection<EmployeeExitRating> EmployeeExitRatingGoodExitRating { get; set; }
        public virtual ICollection<EmployeeExitRating> EmployeeExitRatingPoorExitRating { get; set; }
        public virtual ICollection<EmployeeExitRating> EmployeeExitRatingVeryGoodExitRating { get; set; }
    }
}
