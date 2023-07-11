using System;
using System.Collections.Generic;

namespace HCMIS.Model
{
    public partial class ADisplinaryCategory
    {
        public ADisplinaryCategory()
        {
            EmployeeDisplinary = new HashSet<EmployeeDisplinary>();
        }

        public int DisplinaryCategoryId { get; set; }
        public string? DisplinaryCategoryDescription { get; set; }

        public virtual ICollection<EmployeeDisplinary> EmployeeDisplinary { get; set; }
    }
}
