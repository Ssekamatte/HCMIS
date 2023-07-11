using System;
using System.Collections.Generic;

namespace HCMIS.Model
{
    public partial class AExitRatingAspects
    {
        public AExitRatingAspects()
        {
            EmployeeExitRating = new HashSet<EmployeeExitRating>();
        }

        public int ExitRatingAspectId { get; set; }
        public string? AspectDescription { get; set; }

        public virtual ICollection<EmployeeExitRating> EmployeeExitRating { get; set; }
    }
}
