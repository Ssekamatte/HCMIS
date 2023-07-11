using System;
using System.Collections.Generic;

namespace HCMIS.Model
{
    public partial class ViewEmployeeLeaveRoster
    {
        public int? Employeeid { get; set; }
        public string? EmployeeDetails { get; set; }
        public string? EmailAddress { get; set; }
        public string? OfficialPhoneNumber { get; set; }
        public string? MobileNumber { get; set; }
        public int? JobDescriptionId { get; set; }
        public int? DepartmentId { get; set; }
        public bool? ArchiveRecord { get; set; }
        public string? JobDescription { get; set; }
        public int? JobTitleId { get; set; }
        public string? JobTitleDescription { get; set; }
        public string? DepartmentDescription { get; set; }
        public string? EmployeeNumber { get; set; }
        public DateTime? DateJoined { get; set; }
        public string? AddedBy { get; set; }
        public DateTime? AddedDate { get; set; }
        public string? ApprovedBy { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public string? RejectedBy { get; set; }
        public DateTime? RejectionDate { get; set; }
        public int? LeaveRosterId { get; set; }
        public DateTime? ProposedLeaveStartDate { get; set; }
        public DateTime? ProposedLeaveEndDate { get; set; }
        public int NoofLeaveDays { get; set; }
        public DateTime? ActualLeaveStartDate { get; set; }
        public DateTime? ActualLeaveEndDate { get; set; }
        public bool? IsBlock { get; set; }
        public bool? IsAllDay { get; set; }
    }
}
