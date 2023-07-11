namespace HCMIS.Model
{
    public class ABscPerspectives
    {
        public int BscPerspectiveId { get; set; }
        public int? BscPerspectiveTypeId { get; set; }
        public double? PerspectiveTotalWeight { get; set; }
        public int? DepartmentId { get; set; }
        public int? FinancialYearId { get; set; }
        public string? UserId { get; set; }
        public DateTime? DateAdded { get; set; }
    }
}
