namespace HCMIS.Model
{
    public partial class ViewAvailableJobs
    {
        public int JobOpeningId { get; set; }
        public int? JobDescriptionId { get; set; }
        public int? DepartmentId { get; set; }
        public string? DepartmentDescription { get; set; }
        public int JobTitleId { get; set; }
        public string? JobTitleDescription { get; set; }
        public string? ReportsTo { get; set; }
        public string? ReportsToDesc { get; set; }
        public string? JobDescription { get; set; }
        public int? SalaryScaleId { get; set; }
        public string? SalaryScaleDescription { get; set; }
        public int? JobTypeId { get; set; }
        public string? TypeDescription { get; set; }
        public int? ContractLength { get; set; }
        public int? ContractLengthTypeId { get; set; }
        public string? ContractLengthTypeDesc { get; set; }
        public DateTime? ContractStartDate { get; set; }
        public DateTime? ContractEnddate { get; set; }
        public double? MinimumYearsofExperience { get; set; }
        public int? Vacancies { get; set; }
        public int? MinimumLevelOfEducationId { get; set; }
        public string? LevelofEducationDesc { get; set; }
        public DateTime? ApplicationOpeningDate { get; set; }
        public DateTime? ApplicationClosingDate { get; set; }
        public string? ReferenceNumber { get; set; }
    }
}
