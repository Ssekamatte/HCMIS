using System;
using System.Collections.Generic;

namespace HCMIS.Model
{
    public partial class ADisplinaryCaseStatus
    {
        public ADisplinaryCaseStatus()
        {
            EmployeeDisplinary = new HashSet<EmployeeDisplinary>();
        }

        public int CaseStatusId { get; set; }
        public string? CaseStatusDescription { get; set; }

        public virtual ICollection<EmployeeDisplinary> EmployeeDisplinary { get; set; }
    }
}
