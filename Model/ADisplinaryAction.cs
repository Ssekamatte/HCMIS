using System;
using System.Collections.Generic;

namespace HCMIS.Model
{
    public partial class ADisplinaryAction
    {
        public ADisplinaryAction()
        {
            EmployeeDisplinary = new HashSet<EmployeeDisplinary>();
        }

        public int DisplinaryActionId { get; set; }
        public string? DisplinaryActionDescription { get; set; }
        public bool IsVisible { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<EmployeeDisplinary> EmployeeDisplinary { get; set; }
    }
}
