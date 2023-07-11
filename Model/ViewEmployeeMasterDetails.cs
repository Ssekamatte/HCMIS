using System;
using System.Collections.Generic;

namespace HCMIS.Model
{
    public partial class ViewEmployeeMasterDetails
    {
        public int Employeeid { get; set; }
        public string? EmployeeNumber { get; set; }
        public string EmployeeFullName { get; set; } = null!;
        public int? GenderId { get; set; }
        public string? GenderDesc { get; set; }
        public DateTime? DoB { get; set; }
        public int? IdentificationTypeId { get; set; }
        public string? IdentificationTypeDesc { get; set; }
        public string? IdentificationNumber { get; set; }
        public string? EmailAddress { get; set; }
        public string? OfficialPhoneNumber { get; set; }
        public string? MobileNumber { get; set; }
        public int? CoutryId { get; set; }
        public string? CountryDesc { get; set; }
        public int? MaritalStatusId { get; set; }
        public string? MaritalStatusDescription { get; set; }
        public int? PlaceofOriginDistrictId { get; set; }
        public string? DistrictOrigin { get; set; }
        public int? PlaceofOriginSubCountyId { get; set; }
        public string? SubCountyOrigin { get; set; }
        public int? PlaceofOriginParishId { get; set; }
        public string? ParishOrigin { get; set; }
        public int? PlaceofOriginVillageId { get; set; }
        public string? VillageOrigin { get; set; }
        public int? PlaceofResidenceDistrictId { get; set; }
        public string? DistrictResidence { get; set; }
        public int? PlaceofResidenceSubCountyId { get; set; }
        public string? SubCountyResidence { get; set; }
        public int? PlaceofResidenceParishId { get; set; }
        public string? ParishResidence { get; set; }
        public int? PlaceofResidenceVillageId { get; set; }
        public string? VillageResidence { get; set; }
        public string? Nssfno { get; set; }
        public string? UraTinNo { get; set; }
        public int? BankId { get; set; }
        public string? BankDesc { get; set; }
        public string? BankBranch { get; set; }
        public string? BankAccountNumber { get; set; }
        public string? Photograph { get; set; }
        public string? PhotographExt { get; set; }
        public int? JobDescriptionId { get; set; }
        public string? JobDescription { get; set; }
        public int? DepartmentId { get; set; }
        public string? DepartmentDescription { get; set; }
        public bool? ArchiveRecord { get; set; }
        public DateTime? DateJoined { get; set; }
        public int? DurationatWork { get; set; }
        public DateTime? DepartureDate { get; set; }
        public string? PoboxNumber { get; set; }
        public string? NationalIdentificationNumber { get; set; }
        public string? EmployeFatherName { get; set; }
        public bool? EmployeFatherIsLive { get; set; }
        public string? EmployeMotherName { get; set; }
        public bool? EmployeMotherIsLive { get; set; }
        public string? ContactPersonName { get; set; }
        public string? ContactPersonTelephoneNumber { get; set; }
        public int? ContactPersonRelationShipId { get; set; }
        public string? ContactPersonRelationship { get; set; }
        public string? NextofKinName { get; set; }
        public string? NextofKinTelephoneNumber { get; set; }
        public int? NextofKinRelationShipId { get; set; }
        public string? NextofKinRelationship { get; set; }
        public int? EmployeeLevelId { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public int? JibTitleId { get; set; }
    }
}
