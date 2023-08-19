using HCMIS.SHARED.DTOs.Employeez;
using System;
using System.Collections.Generic;

namespace HCMIS.Model
{
    public partial class ADisplinaryReason
    {
        public ADisplinaryReason()
        {
            EmployeeDisplinary = new HashSet<EmployeeDisciplinaryDto>();
        }

        public int DisplinaryReasonId { get; set; }
        public string? DisplinaryReasonDescription { get; set; }

        public virtual ICollection<EmployeeDisciplinaryDto> EmployeeDisplinary { get; set; }
    }
}
