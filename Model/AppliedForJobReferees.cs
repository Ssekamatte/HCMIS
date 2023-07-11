using System;
using System.Collections.Generic;

namespace HCMIS.Model
{
    public partial class AppliedForJobReferees
    {
        public int AppliedForRefereeId { get; set; }
        public int? AppliedForJobsId { get; set; }
        public string? RefereeName { get; set; }
        public int? GenderId { get; set; }
        public int? CoutryId { get; set; }
        public string? RefereeJobTitle { get; set; }
        public string? RefereeCompany { get; set; }
        public string? RefereeEmail { get; set; }
        public double? RefereePhoneNumber { get; set; }
        public double? RefereeOtherPhoneNumber { get; set; }
        public string? RefereePhysicalAddress { get; set; }

        public virtual AppliedForJobs? AppliedForJobs { get; set; }
        public virtual ACountry? Coutry { get; set; }
        public virtual AGender? Gender { get; set; }
    }
}
