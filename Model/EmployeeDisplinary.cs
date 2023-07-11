namespace HCMIS.Model
{
    public class EmployeeDisplinary
    {
        public int DisplinaryId { get; set; }
        public string? DisplinaryReason { get; set; }
        public int? EmployeeId { get; set; }
        public string? EmployeeResponse { get; set; }
        public string? OfficialDocumentName { get; set; }
        public string? OfficialDocumentExt { get; set; }
        public string? DisplinaryActionDetails { get; set; }
        public int? DisplinaryActionId { get; set; }
        public string? DisplinedBy { get; set; }
        public DateTime? DisplinaryDate { get; set; }
        public bool IsVisible { get; set; }
        public bool IsDeleted { get; set; }
        public int? DisplinaryReasonId { get; set; }
        public string? EmployeeDocumentName { get; set; }
        public string? EmployeeDocumentExt { get; set; }
        public int? DisplinaryWarningId { get; set; }
        public bool? CaseInvestigated { get; set; }
        public int? CaseStatusId { get; set; }
        public int? DisplinaryCategoryId { get; set; }
        public bool? IsSubmitted { get; set; }
        public DateTime? AppealDate { get; set; }
        public DateTime? ReferalDate { get; set; }
        public DateTime? DisplinaryActionDate { get; set; }
        public DateTime? DateSubmitted { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? EmployeeResponseDate { get; set; }
        public string? OfficersDesignation { get; set; }
        public string? EmployeeDisplinaryNumber { get; set; }
    }
}
