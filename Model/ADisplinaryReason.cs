using System;
using System.Collections.Generic;

namespace HCMIS.Model
{
    public partial class ADisplinaryReason
    {
        public ADisplinaryReason()
        {
            EmployeeDisplinary = new HashSet<EmployeeDisplinary>();
        }

        public int DisplinaryReasonId { get; set; }
        public string? DisplinaryReasonDescription { get; set; }

        public virtual ICollection<EmployeeDisplinary> EmployeeDisplinary { get; set; }
    }
}
