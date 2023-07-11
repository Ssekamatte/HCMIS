namespace HCMIS.Model
{
    public class ViewBscEmployee
    {
        public int Employeeid { get; set; }
        public string EmployeeDetails { get; set; } = null!;
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public int? GenderId { get; set; }
        public string? GenderDesc { get; set; }
        public DateTime? DoB { get; set; }
        public int? IdentificationTypeId { get; set; }
        public string? IdentificationNumber { get; set; }
        public string? EmailAddress { get; set; }
        public string? OfficialPhoneNumber { get; set; }
        public string? MobileNumber { get; set; }
        public int? CoutryId { get; set; }
        public int? MaritalStatusId { get; set; }
        public int? PlaceofOriginDistrictId { get; set; }
        public int? PlaceofOriginSubCountyId { get; set; }
        public int? PlaceofOriginParishId { get; set; }
        public int? PlaceofOriginVillageId { get; set; }
        public int? PlaceofResidenceDistrictId { get; set; }
        public int? PlaceofResidenceSubCountyId { get; set; }
        public int? PlaceofResidenceParishId { get; set; }
        public int? PlaceofResidenceVillageId { get; set; }
        public string? Nssfno { get; set; }
        public string? UraTinNo { get; set; }
        public int? BankId { get; set; }
        public string? BankBranch { get; set; }
        public string? BankAccountNumber { get; set; }
        public string? Photograph { get; set; }
        public string? PhotographExt { get; set; }
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
        public string? ReportsTo { get; set; }
        public int? HoDemployeeId { get; set; }
    }
}
