namespace HCMIS.Model
{
    public class ViewDisciplinaryCommittee
    {
        public int Employeeid { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string EmployeeName { get; set; } = null!;
        public string? EmailAddress { get; set; }
        public string? OfficialPhoneNumber { get; set; }
        public int? GenderId { get; set; }
        public DateTime? DoB { get; set; }
        public int? JobDescriptionId { get; set; }
        public int? DepartmentId { get; set; }
        public DateTime? DateJoined { get; set; }
        public int? DurationatWork { get; set; }
        public string? EmployeeNumber { get; set; }
        public string? DepartmentDescription { get; set; }
        public string? JobDescription { get; set; }
    }
}
