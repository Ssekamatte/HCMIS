﻿using HCMIS.SHARED.DTOs.Employeez;
using System;
using System.Collections.Generic;

namespace HCMIS.Model
{
    public partial class ADisplinaryCaseStatus
    {
        public ADisplinaryCaseStatus()
        {
            EmployeeDisplinary = new HashSet<EmployeeDisciplinaryDto>();
        }

        public int CaseStatusId { get; set; }
        public string? CaseStatusDescription { get; set; }

        public virtual ICollection<EmployeeDisciplinaryDto> EmployeeDisplinary { get; set; }
    }
}
