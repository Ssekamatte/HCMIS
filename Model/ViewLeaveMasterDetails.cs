using System;
using System.Collections.Generic;

namespace HCMIS.Model
{
    public partial class ViewLeaveMasterDetails
    {
        public int LeaveRosterId { get; set; }
        public int? Employeeid { get; set; }
        public string? LeaveRosterCreatedBy { get; set; }
        public DateTime? LeaveRosterCreatedDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? DepartmentId { get; set; }
        public string? DepartmentDescription { get; set; }
        public int? LeaveTypeId { get; set; }
        public string? LeaveTypeDescription { get; set; }
        public bool? IsBlock { get; set; }
        public int? LeaveDeductions { get; set; }
        public int? NumberofLeaveDaysAppliedFor { get; set; }
        public DateTime? LastWorkingDay { get; set; }
        public DateTime? DateofResumptionofWork { get; set; }
        public bool? SalaryRequestedInAdvance { get; set; }
        public DateTime? LeaveDateApplied { get; set; }
        public DateTime? SubmittedDate { get; set; }
        public string? SubmittedBy { get; set; }
        public DateTime? LeaveRosterApprovedDate { get; set; }
        public string? LeaveApplicationNumber { get; set; }
    }
}
