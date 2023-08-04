using System;
using System.Collections.Generic;

namespace HCMIS.Model
{
    public partial class ViewUserManagement
    {
        public string Id { get; set; } = null!;
        public string? UserName { get; set; }
        public string? NormalizedUserName { get; set; }
        public string? Email { get; set; }
        public string? NormalizedEmail { get; set; }
        public bool EmailConfirmed { get; set; }
        public string? PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public DateTimeOffset? LockoutEnd { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public int? NonStaffid { get; set; }
        public int? Employeeid { get; set; }
        public string? RoleId { get; set; }
        public string? RoleName { get; set; }
        public string? NormalizedRoleName { get; set; }
        public string? FullName { get; set; }
        public int? GenderId { get; set; }
        public string? EmailAddress { get; set; }
        public string? OfficialPhoneNumber { get; set; }
        public double? OfficePhoneNumber { get; set; }
        public string? MobileNumber { get; set; }
        public int? JobDescriptionId { get; set; }
        public string? JobDescription { get; set; }
        public int? JibTitleId { get; set; }
        public string? JobTitleDescription { get; set; }
        public int? DepartmentId { get; set; }
        public string? DepartmentDescription { get; set; }
        public int? EmployeeLevelId { get; set; }
        public string? EmployeeLevelDesc { get; set; }
        public int? HoDemployeeId { get; set; }
    }
}
