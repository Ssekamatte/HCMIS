using HCMIS.SHARED.DTOs.Employeez;
using System;
using System.Collections.Generic;

namespace HCMIS.Model
{
    public partial class ViewEmployeeLeaveRoster
    {
        public int? LeaveRosterId { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime? ProposedLeaveStartDate { get; set; }
        public DateTime? ProposedLeaveEndDate { get; set; }
        public DateTime? ActualLeaveStartDate { get; set; }
        public DateTime? ActualLeaveEndDate { get; set; }
        public string? AddedBy { get; set; }
        public DateTime? AddedDate { get; set; }
        public string? ApprovedBy { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public string? RejectedBy { get; set; }
        public DateTime? RejectionDate { get; set; }
        public bool? IsBlock { get; set; }
        public bool? IsAllDay { get; set; }
        public int? NoofDays { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public int? GenderId { get; set; }
        public string? FirstName { get; set; }
        public string? EmployeeDetails { get; set; }
        public int? DepartmentId { get; set; }
        public string? DepartmentDescription { get; set; }
        public bool? ArchiveRecord { get; set; }
    }
}
