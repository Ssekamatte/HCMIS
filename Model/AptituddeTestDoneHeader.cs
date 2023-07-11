using System;
using System.Collections.Generic;

namespace HCMIS.Models
{
    public partial class AptituddeTestDoneHeader
    {
        public int AptituddeTestDoneId { get; set; }
        public int? AppliedForJobsId { get; set; }
        public int? NonStaffid { get; set; }
        public int? Employeeid { get; set; }
        public int? AptituddeTestHeaderId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsSubmitted { get; set; }
    }
}
