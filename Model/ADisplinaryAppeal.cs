using HCMIS.SHARED.DTOs.Employeez;
using System;
using System.Collections.Generic;

namespace HCMIS.Model
{
    public partial class ADisplinaryAppeal
    {
        public int AppealId { get; set; }
        public string? AppealDescription { get; set; }
        public int? EmployeeDisplinaryId { get; set; }
        public string? AppealCreatedBy { get; set; }
        public DateTime? AppealCreatedDate { get; set; }

        public virtual EmployeeDisciplinaryDto? EmployeeDisplinary { get; set; }
    }
}
