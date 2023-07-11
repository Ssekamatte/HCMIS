using HCMIS.Model;
using HCMIS.Model.JobDescriptionModel;

namespace HCMIS.DTOs
{
    public class AppliedForJobDTO
    {
        public int AppliedForJobsId { get; set; }

        public int? JobOpeningId { get; set; }

        public string? ReferenceNumber { get; set; }

        public DateTime? ApplicationOpeningDate { get; set; }

        public DateTime? ApplicationClosingDate { get; set; }

        public int? JobDescriptionId { get; set; }

        public int? JibTitleId { get; set; }

        public string? JobTitleDescription { get; set; }
        public string? ReportsTo { get; set; }

        public string? ReportsToDesc { get; set; }

        public string? JobDescription { get; set; }

        public int? DepartmentId { get; set; }

        public string? DepartmentDescription { get; set; }

        public int? JobTypeId { get; set; }

        public string? TypeDescription { get; set; }

        public int? vacancies { get; set; }

        public int? SalaryScaleId { get; set; }

        public string? SalaryScaleDescription { get; set; }

        public double? MinimumYearsofExperience { get; set; }

        public int? MinimumLevelOfEducationId { get; set; }

        public string? MinimumLevelofEducationDesc { get; set; }

        public DateTime? ContractEnddate { get; set; }

        public DateTime? ContractStartDate { get; set; }

        public int? ContractLength { get; set; }

        public int? ContractLengthTypeId { get; set; }

        public string? ContractLengthTypeDesc { get; set; }

        public int? NonStaffid { get; set; }

        public int? Employeeid { get; set; }

        public string? FullName { get; set; }

        public string? EmailAddress { get; set; }

        public DateTime? DoB { get; set; }

        public int? GenderId { get; set; }

        public string? GenderDesc { get; set; }

        public int? CoutryId { get; set; }

        public string? CountryDesc { get; set; }

        public string? CVDocumentExt { get; set; }

        public string? CVDocumentName { get; set; }

        public int? IdentificationTypeId { get; set; }

        public string? IdentificationTypeDesc { get; set; }

        public string? IdentificationNumber { get; set; }

        public int? MaritalStatusId { get; set; }

        public string? MaritalStatusDescription { get; set; }

        public double? MobileNumber { get; set; }

        public double OfficePhoneNumber { get; set; }

        public double? OfficialPhoneNumber { get; set; }

        public string? Photograph { get; set; }

        public string? PhotographExt { get; set; }

        public int? PlaceofOriginDistrictId { get; set; }

        public string? PlaceofOriginDistrictDesc { get; set; }

        public int? PlaceofOriginParishId { get; set; }

        public string? PlaceofOriginParishDesc { get; set; }

        public int? PlaceofOriginSubCountyId { get; set; }

        public string? PlaceofOriginSubCountyDesc { get; set; }

        public int? PlaceofOriginVillageId { get; set; }

        public string? PlaceofOriginVillageDesc { get; set; }

        public int? PlaceofResidenceDistrictId { get; set; }

        public string? PlaceofResidenceDistrictDesc { get; set; }

        public int? PlaceofResidenceParishId { get; set; }

        public string? PlaceofResidenceParishDesc { get; set; }

        public int? PlaceofResidenceSubCountyId { get; set; }

        public string? PlaceofResidenceSubCountyDesc { get; set; }

        public int? PlaceofResidenceVillageId { get; set; }

        public string? PlaceofResidenceVillageDesc { get; set; }

        public string? URA_TinNo { get; set; }

        public string? LinkedIn { get; set; }

        public string? NSSFNo { get; set; }

        public string? Twitter { get; set; }

        public int? ApplicationStatusId { get; set; }

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
        public List<AppliedForJobReferees>? appliedForJobReferees { get; set; }
        public List<NonStaffLanguagesKnown>? LanguagesKnown { get; set; }
        public List<NonStaffQualification>? Qualification { get; set; }
        public List<NonStaffWorkExperience>? WorkExperience { get; set; }
        public List<NonStaffSkills>? Skills { get; set; }
        public List<ViewJobDescriptionKnowledge>? JobDescriptionKnowledgeData { get; set; }
        public List<JobDescriptionWorkExperienceRequirement>? JobDescriptionWorkExperienceRequirementData { get; set; }
        public List<JobDescriptionResponsibility>? JobDescriptionResponsibilityData { get; set; }
        public List<AppliedForJobsComment>? AppliedForJobsCommentData { get; set; }
    }
}
