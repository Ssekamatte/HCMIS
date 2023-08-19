using HCMIS.SHARED.DTOs.Employeez;
using System;
using System.Collections.Generic;

namespace HCMIS.Model
{
    public partial class ADisplinaryWarning
    {
        public ADisplinaryWarning()
        {
            EmployeeDisplinary = new HashSet<EmployeeDisciplinaryDto>();
        }

        public int DisplinaryWarningId { get; set; }
        public string? WarningDescription { get; set; }
        public string? DisplinaryActionId { get; set; }

        public virtual ICollection<EmployeeDisciplinaryDto> EmployeeDisplinary { get; set; }
    }
}
