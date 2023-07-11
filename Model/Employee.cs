using HCMIS.Model;
using HCMIS.Model.JobDescriptionModel;
using System;
using System.Collections.Generic;

namespace HCMIS.Model
{
    public partial class Employee
    {
        //public Employee()
        //{
        //    AEmployeeChildren = new HashSet<AEmployeeChildren>();
        //    AEmployeeParents = new HashSet<AEmployeeParents>();
        //    ALeaveRoster = new HashSet<ALeaveRoster>();
        //    EmployeeAttendence = new HashSet<EmployeeAttendence>();
        //    EmployeeDisplinary = new HashSet<EmployeeDisplinary>();
        //    EmployeeLanguagesKnown = new HashSet<EmployeeLanguagesKnown>();
        //    EmployeeLeave = new HashSet<EmployeeLeave>();
        //    EmployeeNextOfKin = new HashSet<EmployeeNextOfKin>();
        //    EmployeeQualification = new HashSet<EmployeeQualification>();
        //    EmployeeSpouse = new HashSet<EmployeeSpouse>();
        //    EmployeeWorkExperience = new HashSet<EmployeeWorkExperience>();
        //}

        //public int Employeeid { get; set; }
        //public string? FirstName { get; set; }
        //public string? MiddleName { get; set; }
        //public string? LastName { get; set; }
        //public int? GenderId { get; set; }
        //public DateTime? DoB { get; set; }
        //public int? IdentificationTypeId { get; set; }
        //public string? IdentificationNumber { get; set; }
        //public string? EmailAddress { get; set; }
        //public string? OfficialPhoneNumber { get; set; }
        //public string? MobileNumber { get; set; }
        //public int? CoutryId { get; set; }
        //public string? LinkedIn { get; set; }
        //public string? Github { get; set; }
        //public string? Twitter { get; set; }
        //public string? CvdocumentName { get; set; }
        //public string? CvdocumentExt { get; set; }
        //public int? MaritalStatusId { get; set; }
        //public int? PlaceofOriginDistrictId { get; set; }
        //public int? PlaceofOriginSubCountyId { get; set; }
        //public int? PlaceofOriginParishId { get; set; }
        //public int? PlaceofOriginVillageId { get; set; }
        //public int? PlaceofResidenceDistrictId { get; set; }
        //public int? PlaceofResidenceSubCountyId { get; set; }
        //public int? PlaceofResidenceParishId { get; set; }
        //public int? PlaceofResidenceVillageId { get; set; }
        //public string? Nssfno { get; set; }
        //public string? UraTinNo { get; set; }
        //public int? BankId { get; set; }
        //public string? BankBranch { get; set; }
        //public string? BankAccountNumber { get; set; }
        //public string? Photograph { get; set; }
        //public string? PhotographExt { get; set; }
        //public int? JobDescriptionId { get; set; }
        //public int? DepartmentId { get; set; }
        //public bool ArchiveRecord { get; set; }
        //public string? EmployeeNumber { get; set; }
        //public DateTime? DateJoined { get; set; }
        //public DateTime? DepartureDate { get; set; }
        //public string? PoboxNumber { get; set; }
        //public string? NationalIdentificationNumber { get; set; }
        //public string? EmployeFatherName { get; set; }
        //public bool? EmployeFatherIsLive { get; set; }
        //public string? EmployeMotherName { get; set; }
        //public bool? EmployeMotherIsLive { get; set; }
        //public string? ContactPersonName { get; set; }
        //public string? ContactPersonTelephoneNumber { get; set; }
        //public int? ContactPersonRelationshipId { get; set; }
        //public string? NextofKinName { get; set; }
        //public string? NextofKinTelephoneNumber { get; set; }
        //public int? NextofKinRelationshipId { get; set; }

        //public virtual ABank? Bank { get; set; }
        //public virtual ARelationship? ContactPersonRelationship { get; set; }
        //public virtual ACountry? Coutry { get; set; }
        //public virtual ADepartment? Department { get; set; }
        //public virtual AGender? Gender { get; set; }
        //public virtual AIdentificationType? IdentificationType { get; set; }
        //public virtual JobDescription? JobDescription { get; set; }
        //public virtual AMaritalStatus? MaritalStatus { get; set; }
        //public virtual ARelationship? NextofKinRelationship { get; set; }
        //public virtual ADistrict? PlaceofOriginDistrict { get; set; }
        //public virtual AParish? PlaceofOriginParish { get; set; }
        //public virtual ASubCounty? PlaceofOriginSubCounty { get; set; }
        //public virtual AVillage? PlaceofOriginVillage { get; set; }
        //public virtual ADistrict? PlaceofResidenceDistrict { get; set; }
        //public virtual AParish? PlaceofResidenceParish { get; set; }
        //public virtual ASubCounty? PlaceofResidenceSubCounty { get; set; }
        //public virtual AVillage? PlaceofResidenceVillage { get; set; }
        //public virtual ICollection<AEmployeeChildren> AEmployeeChildren { get; set; }
        //public virtual ICollection<AEmployeeParents> AEmployeeParents { get; set; }
        //public virtual ICollection<ALeaveRoster> ALeaveRoster { get; set; }
        //public virtual ICollection<EmployeeAttendence> EmployeeAttendence { get; set; }
        //public virtual ICollection<EmployeeDisplinary> EmployeeDisplinary { get; set; }
        //public virtual ICollection<EmployeeLanguagesKnown> EmployeeLanguagesKnown { get; set; }
        //public virtual ICollection<EmployeeLeave> EmployeeLeave { get; set; }
        //public virtual ICollection<EmployeeNextOfKin> EmployeeNextOfKin { get; set; }
        //public virtual ICollection<EmployeeQualification> EmployeeQualification { get; set; }
        //public virtual ICollection<EmployeeSpouse> EmployeeSpouse { get; set; }
        //public virtual ICollection<EmployeeWorkExperience> EmployeeWorkExperience { get; set; }
        public Employee()
        {
          //  ADisciplinaryCommittee = new HashSet<ADisciplinaryCommittee>();
            AEmployeeChildren = new HashSet<AEmployeeChildren>();
            AEmployeeParents = new HashSet<AEmployeeParents>();
            AppliedForJobs = new HashSet<AppliedForJobs>();
            EmployeeAttendence = new HashSet<EmployeeAttendence>();
            EmployeeDisplinary = new HashSet<EmployeeDisplinary>();
            EmployeeExitInterview = new HashSet<EmployeeExitInterview>();
            EmployeeLanguagesKnown = new HashSet<EmployeeLanguagesKnown>();
            EmployeeNextOfKin = new HashSet<EmployeeNextOfKin>();
            EmployeeQualification = new HashSet<EmployeeQualification>();
            EmployeeSpouse = new HashSet<EmployeeSpouse>();
            EmployeeWorkExperience = new HashSet<EmployeeWorkExperience>();
           // Exit = new HashSet<Exit>();
           // TrainingAssessmentSurvey = new HashSet<TrainingAssessmentSurvey>();
           // TrainingSubscription = new HashSet<TrainingSubscription>();
        }

        public int Employeeid { get; set; }
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
        public string? LinkedIn { get; set; }
        public string? Github { get; set; }
        public string? Twitter { get; set; }
        public string? CvdocumentName { get; set; }
        public string? CvdocumentExt { get; set; }
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
        public string? EmployeeNumber { get; set; }
        public DateTime? DateJoined { get; set; }
        public DateTime? DepartureDate { get; set; }
        public int? NextofKinRelationShipId { get; set; }
        public string? NextofKinTelephoneNumber { get; set; }
        public string? NextofKinName { get; set; }
        public int? ContactPersonRelationShipId { get; set; }
        public string? ContactPersonTelephoneNumber { get; set; }
        public string? ContactPersonName { get; set; }
        public bool? EmployeMotherIsLive { get; set; }
        public string? EmployeMotherName { get; set; }
        public string? EmployeFatherName { get; set; }
        public bool? EmployeFatherIsLive { get; set; }
        public string? PoboxNumber { get; set; }
        public bool ArchiveRecord { get; set; }
        public string? NationalIdentificationNumber { get; set; }
        public int? EmployeeLevelId { get; set; }

        public virtual ARelationship? ContactPersonRelationShip { get; set; }
        public virtual ARelationship? NextofKinRelationShip { get; set; }
        public virtual ICollection<AEmployeeChildren> AEmployeeChildren { get; set; }
        public virtual ICollection<AEmployeeParents> AEmployeeParents { get; set; }
        public virtual ICollection<AppliedForJobs> AppliedForJobs { get; set; }
        public virtual ICollection<EmployeeAttendence> EmployeeAttendence { get; set; }
        public virtual ICollection<EmployeeDisplinary> EmployeeDisplinary { get; set; }
        public virtual ICollection<EmployeeExitInterview> EmployeeExitInterview { get; set; }
        public virtual ICollection<EmployeeLanguagesKnown> EmployeeLanguagesKnown { get; set; }
        public virtual ICollection<EmployeeNextOfKin> EmployeeNextOfKin { get; set; }
        public virtual ICollection<EmployeeQualification> EmployeeQualification { get; set; }
        public virtual ICollection<EmployeeSpouse> EmployeeSpouse { get; set; }
        public virtual ICollection<EmployeeWorkExperience> EmployeeWorkExperience { get; set; }
       // public virtual ICollection<Exit> Exit { get; set; }
       // public virtual ICollection<TrainingAssessmentSurvey> TrainingAssessmentSurvey { get; set; }
       // public virtual ICollection<TrainingSubscription> TrainingSubscription { get; set; }


    }
}
