using System;
using System.Collections.Generic;

namespace HCMIS.Model
{
    public partial class ViewDisplinaryMasterDetails
    {
        public int DisplinaryId { get; set; }
        public string? DisplinaryReason { get; set; }
        public int? EmployeeId { get; set; }
        public int? DisplinaryActionId { get; set; }
        public string? DisplinaryActionDescription { get; set; }
        public string? DisplinedBy { get; set; }
        public DateTime? DisplinaryDate { get; set; }
        public bool IsVisible { get; set; }
        public bool IsDeleted { get; set; }
        public int? DisplinaryReasonId { get; set; }
        public string? DisplinaryReasonDescription { get; set; }
        public int? DisplinaryWarningId { get; set; }
        public string? WarningDescription { get; set; }
        public int? CaseStatusId { get; set; }
        public string? CaseStatusDescription { get; set; }
        public DateTime? DisplinaryActionDate { get; set; }
        public string? EmployeeDisplinaryNumber { get; set; }
        public DateTime? DateCreated { get; set; }
        public string? OfficersDesignation { get; set; }
    }
}
