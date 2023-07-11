using System;
using System.Collections.Generic;

namespace HCMIS.Model
{
    public partial class ViewEmployeeLeaveDetails
    {
        public int Employeeid { get; set; }
        public string EmployeeDetails { get; set; } = null!;
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public int? GenderId { get; set; }
        public DateTime? DoB { get; set; }
        public int? IdentificationTypeId { get; set; }
        public string? IdentificationNumber { get; set; }
        public string? EmailAddress { get; set; }
        public string? OfficialPhoneNumber { get; set; }
        public string? MobileNumber { get; set; }
        public int? CoutryId { get; set; }
        public int? MaritalStatusId { get; set; }
        public string? Nssfno { get; set; }
        public string? UraTinNo { get; set; }
        public int? BankId { get; set; }
        public string? BankBranch { get; set; }
        public string? BankAccountNumber { get; set; }
        public int? JobDescriptionId { get; set; }
        public int? DepartmentId { get; set; }
        public bool ArchiveRecord { get; set; }
        public string? JobDescription { get; set; }
        public int? JobTitleId { get; set; }
        public string? JobTitleDescription { get; set; }
        public string? DepartmentDescription { get; set; }
        public string? EmployeeNumber { get; set; }
        public DateTime? DateJoined { get; set; }
        public DateTime? DepartureDate { get; set; }
        public int? DurationatWork { get; set; }
        public DateTime? PartiallyApprovedLeaveDateFrom { get; set; }
        public int? EmployeeLeaveId { get; set; }
        public double? LeaveEntitlement { get; set; }
        public int? DaysAppliedFor { get; set; }
        public bool? SalaryRequestedInAdvance { get; set; }
        public DateTime? DateOfResumptionToWork { get; set; }
        public int? Expr1 { get; set; }
        public int? YesNoId { get; set; }
        public DateTime? PartiallyApprovedFromDate { get; set; }
        public DateTime? PartiallyApprovedToDate { get; set; }
        public string? SupervisorApproval { get; set; }
        public DateTime? SupervisorApprovalDate { get; set; }
        public string? HeadofDepartmentApproval { get; set; }
        public DateTime? HeadofDepartmentApprovalDate { get; set; }
        public string? ChiefExecutiveOfficerApproval { get; set; }
        public DateTime? ChiefExecutiveOfficerApprovalDate { get; set; }
        public int? LeaveApprovalId { get; set; }
        public int? BalanceBroughtFromPreviousYear { get; set; }
        public int? LeaveEntitlementForCurrentYear { get; set; }
        public int? TotalLeaveDue { get; set; }
        public int? LessLeaveAppliedFor { get; set; }
        public int? BalanceInHandOnReturn { get; set; }
        public int? OtherEntitlements { get; set; }
        public string? LeaveRemarks { get; set; }
        public string? HeadHumanResourceandAdministrationApproval { get; set; }
        public DateTime? HeadHumanResourceandAdministrationApprovalDate { get; set; }
        public double? SalaryAdvance { get; set; }
        public string? ChiefHumanResourceOfficerApproval { get; set; }
        public DateTime? ChiefHumanResourceOfficerApprovalDate { get; set; }
        public DateTime? LeaveRequestDate { get; set; }
        public bool? IsSubmitted { get; set; }
        public string? LeaveReferenceNumber { get; set; }
        public int? LeaveApprovalStatusId { get; set; }
        public DateTime? LastWorkingDay { get; set; }
        public DateTime? PartiallyApprovedLeaveDateTo { get; set; }
        public int? PartiallyApprovedLeaveNumberofDays { get; set; }
        public string? PoboxNumber { get; set; }
        public string? NationalIdentificationNumber { get; set; }
    }
}
