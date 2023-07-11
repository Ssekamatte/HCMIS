using System;
using System.Collections.Generic;

namespace HCMIS.Model
{
    public partial class EmployeeLeaveRosterDto
    {
        public int LeaveRosterId { get; set; }
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
    }
}
