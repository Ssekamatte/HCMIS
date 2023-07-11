using HCMIS.Model;
using HCMIS.SHARED;
using System;
using System.Collections.Generic;

namespace HCMIS.Model
{
    public partial class AEmployeeParents
    {
        public int EmployeeParentsId { get; set; }
        public int? EmployeeId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public bool? IsLive { get; set; }
        public int? RelationshipId { get; set; }

        public virtual EmployeeDto? Employee { get; set; }
        public virtual ARelationship? Relationship { get; set; }
    }
}
