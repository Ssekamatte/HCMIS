using System;
using System.Collections.Generic;

namespace HCMIS.Model
{
    public partial class ExitClearanceCertificate
    {
        public int ClearanceId { get; set; }
        public string? EmployeeName { get; set; }
        public bool? OfficeKeys { get; set; }
        public bool? DrawerKeys { get; set; }
        public bool? SafeKeys { get; set; }
        public bool? Car { get; set; }
        public bool? CarKeys { get; set; }
        public bool? OfficialDocuments { get; set; }
        public bool? ChequeBooks { get; set; }
        public bool? OfficialStamps { get; set; }
        public string? Others { get; set; }
        public string? HeadOfDepartmmentBy { get; set; }
        public bool? HeadOfDepartmmentSigned { get; set; }
        public DateTime? HeadOfDepartmmentDateSigned { get; set; }
        public string? HeadOfDepartmmentPosition { get; set; }
        public string? OutstandingAccountabilities { get; set; }
        public string? ChiefFinanceOfficerBy { get; set; }
        public bool? ChiefFinanceOfficerSigned { get; set; }
        public DateTime? ChiefFinanceOfficerDateSigned { get; set; }
        public string? StaffIdentityCardNo { get; set; }
        public string? MedicalCards { get; set; }
        public bool? MedicalCardsSubmitted { get; set; }
        public bool? StaffIdentityCardSubmitted { get; set; }
        public decimal? OutstandingStaffAdvance { get; set; }
        public string? ChrOfficerOthers { get; set; }
        public string? ChiefHumanResourceOfficerBy { get; set; }
        public DateTime? ChiefHumanResourceOfficerDateSigned { get; set; }
        public bool? ChiefHumanResourceOfficerSigned { get; set; }
        public DateTime? AcknowledgeBenefitsDateSigned { get; set; }
        public bool? AcknowledgeBenefitsSigned { get; set; }
        public string? MemberName { get; set; }
        public string? AcknowledgeBenefitsBy { get; set; }
        public int? ExitInterviewId { get; set; }

        public virtual EmployeeExitInterview? ExitInterview { get; set; }
    }
}
