using HCMIS.SHARED.DTOs.Employeez;
using System;
using System.Collections.Generic;

namespace HCMIS.Model
{
    public partial class ADisplinaryCategory
    {
        public ADisplinaryCategory()
        {
            EmployeeDisplinary = new HashSet<EmployeeDisciplinaryDto>();
        }

        public int DisplinaryCategoryId { get; set; }
        public string? DisplinaryCategoryDescription { get; set; }

        public virtual ICollection<EmployeeDisciplinaryDto> EmployeeDisplinary { get; set; }
    }
}
