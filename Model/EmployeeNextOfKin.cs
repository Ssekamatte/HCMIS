using HCMIS.Model;
using HCMIS.SHARED;
using System;
using System.Collections.Generic;

namespace HCMIS.Model
{
    public partial class EmployeeNextOfKin
    {
        public int EmployeeNextOfKinId { get; set; }
        public int Employeeid { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public int? GenderId { get; set; }
        public string? EmailAddress { get; set; }
        public double? OfficialPhoneNumber { get; set; }
        public double? MobileNumber { get; set; }
        public int? RelationshipId { get; set; }
        public int? PlaceofResidenceParishId { get; set; }
        public int? PlaceofResidenceVillageId { get; set; }
        public int? PlaceofResidenceDistrictId { get; set; }
        public int? NationalityId { get; set; }
        public bool? IsAlive { get; set; }
        public int? PlaceofResidenceSubcountyId { get; set; }

        public virtual EmployeeDto? Employee { get; set; } = null!;
        public virtual AGender? Gender { get; set; }
        public virtual ACountry? Nationality { get; set; }
        public virtual ADistrict? PlaceofResidenceDistrict { get; set; }
        public virtual AParish? PlaceofResidenceParish { get; set; }
        public virtual ASubCounty? PlaceofResidenceSubcounty { get; set; }
        public virtual AVillage? PlaceofResidenceVillage { get; set; }
        public virtual ARelationship? Relationship { get; set; }
    }
}
