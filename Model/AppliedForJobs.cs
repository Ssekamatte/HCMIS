namespace HCMIS.Model
{
    public class AppliedForJobs
    {
        public int AppliedForJobsId { get; set; }
        public int? JobOpeningId { get; set; }
        public int? NonStaffid { get; set; }
        public int? Employeeid { get; set; }
        public int? ApplicationStatusId { get; set; }
        public DateTime? ApplicationDate { get; set; }
        public int? AreYouRelatedToAnyCompanyStaff { get; set; }
        public int? NoOfChildren { get; set; }
        public int? PreviouslyAppliedForAjob { get; set; }
        public string? AppointmentDetail { get; set; }
        public int? EverBeenConvicted { get; set; }
        public string? ConvictionReason { get; set; }
        public bool InformationAcknowledgement { get; set; }
        public int? AptituddeTestHeaderId { get; set; }
        public double? AptituddeTestPassMark { get; set; }
        public double? AptituddeTestApplicantScore { get; set; }
    }
}
