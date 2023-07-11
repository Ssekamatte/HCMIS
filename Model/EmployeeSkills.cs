using HCMIS.Model;
using System;
using System.Collections.Generic;

namespace HCMIS.Model
{
    public partial class EmployeeSkills
    {
        public int ExtraSkillsId { get; set; }
        public int Employeeid { get; set; }
        public string? SkillDescription { get; set; }
        public int? SkillLevelId { get; set; }
        public int? YearsofExperience { get; set; }

        public virtual ASkillLevel? SkillLevel { get; set; }
    }
}
