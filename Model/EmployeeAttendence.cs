using HCMIS.SHARED;
using System;
using System.Collections.Generic;

namespace HCMIS.Model
{
    public partial class EmployeeAttendence
    {
        public int EmployeeAttendenceId { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime? DateNotAttendend { get; set; }
        public DateTime? DateAttended { get; set; }
        public string? ReasonForNotAttending { get; set; }

        public virtual EmployeeDto? Employee { get; set; }
    }
}
