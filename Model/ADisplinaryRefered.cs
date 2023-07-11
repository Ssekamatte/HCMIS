using System;
using System.Collections.Generic;

namespace HCMIS.Model
{
    public partial class ADisplinaryRefered
    {
        public int ReferedId { get; set; }
        public string? ReferedDescription { get; set; }
        public string? ReferedBy { get; set; }
        public DateTime? ReferedDate { get; set; }
        public int? EmployeeDisplinaryId { get; set; }

        public virtual EmployeeDisplinary? EmployeeDisplinary { get; set; }
    }
}
