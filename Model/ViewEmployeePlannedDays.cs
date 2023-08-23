using System;
using System.Collections.Generic;

namespace HCMIS.Model
{
    public partial class ViewEmployeePlannedDays
    {
        public int? EmployeeId { get; set; }
        public DateTime? ProposedLeaveStartDate { get; set; }
        public DateTime? ProposedLeaveEndDate { get; set; }
    }
}
