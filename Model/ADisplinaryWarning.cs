using System;
using System.Collections.Generic;

namespace HCMIS.Model
{
    public partial class ADisplinaryWarning
    {
        public ADisplinaryWarning()
        {
            EmployeeDisplinary = new HashSet<EmployeeDisplinary>();
        }

        public int DisplinaryWarningId { get; set; }
        public string? WarningDescription { get; set; }
        public string? DisplinaryActionId { get; set; }

        public virtual ICollection<EmployeeDisplinary> EmployeeDisplinary { get; set; }
    }
}
