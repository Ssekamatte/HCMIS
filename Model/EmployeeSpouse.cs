using HCMIS.Model;
using System;
using System.Collections.Generic;

namespace HCMIS.Model
{
    public partial class EmployeeSpouse
    {
        public int EmployeeSpouseId { get; set; }
        public int? EmployeeId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public bool? IsLive { get; set; }
        public int? RelationshipId { get; set; }
        public string? Photograph { get; set; }
        public string? MiddleName { get; set; }

        public virtual Employee? Employee { get; set; }
        public virtual ARelationship? Relationship { get; set; }
    }
}
