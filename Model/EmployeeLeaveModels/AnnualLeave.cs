namespace HCMIS.Model.EmployeeLeaveModels
{
    public class AnnualLeave
    {
        public int SchedularId { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime? ScheduledStartDate { get; set; }
        public DateTime? ScheduledEndDate { get; set; }
        public double? NumberofDays { get; set; }

    }
}
