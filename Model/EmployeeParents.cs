using HCMIS.Model;
using HCMIS.SHARED;
using System;
using System.Collections.Generic;

namespace HCMIS.Model
{
    public partial class EmployeeParents
    {
        public int? EmployeeKidsId { get; set; }
        public int? EmployeeId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public bool? IsLive { get; set; }
        public int? RelationshipId { get; set; }
        public string? Photograph { get; set; }

        public virtual EmployeeDto? Employee { get; set; }
        public virtual ARelationship? Relationship { get; set; }
    }
}
