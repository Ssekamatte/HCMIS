namespace HCMIS.Model
{
    public partial class ViewAppliedForJobs
    {
        public int AppliedForJobsId { get; set; }
        public int? JobOpeningId { get; set; }
        public int? JobDescriptionId { get; set; }
        public int? JibTitleId { get; set; }
        public string? JobTitleDescription { get; set; }
        public string? ReportsTo { get; set; }
        public int? DepartmentId { get; set; }
        public string? DepartmentDescription { get; set; }
        public int? SalaryScaleId { get; set; }
        public string? SalaryScaleDescription { get; set; }
        public string? JobDescription { get; set; }
        public int? JobTypeId { get; set; }
        public string? TypeDescription { get; set; }
        public int? ContractLength { get; set; }
        public int? ContractLengthTypeId { get; set; }
        public string? ContractLengthTypeDesc { get; set; }
        public DateTime? ContractStartDate { get; set; }
        public DateTime? ContractEnddate { get; set; }
        public int? Vacancies { get; set; }
        public DateTime? ApplicationOpeningDate { get; set; }
        public DateTime? ApplicationClosingDate { get; set; }
        public int? NonStaffid { get; set; }
        public int? Employeeid { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public int? GenderId { get; set; }
        public DateTime? DoB { get; set; }
        public string? GenderDesc { get; set; }
        public int? ApplicationStatusId { get; set; }
        public string? ApplicationStatusDesc { get; set; }
        public DateTime? ApplicationDate { get; set; }
        public int? AreYouRelatedToAnyCompanyStaff { get; set; }
        public string? AreYouRelatedToAnyCompanyStaffDesc { get; set; }
        public int? NoOfChildren { get; set; }
        public int? PreviouslyAppliedForAjob { get; set; }
        public string? PreviouslyAppliedForAjobDesc { get; set; }
        public string? AppointmentDetail { get; set; }
        public int? EverBeenConvicted { get; set; }
        public string? EverBeenConvictedDesc { get; set; }
        public string? ConvictionReason { get; set; }
        public bool InformationAcknowledgement { get; set; }
        public int? AptituddeTestHeaderId { get; set; }
        public double? AptituddeTestPassMark { get; set; }
        public double? AptituddeTestApplicantScore { get; set; }
    }
}
