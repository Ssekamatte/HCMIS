namespace HCMIS.Data
{
    public class AppraisalSearch
    {
        public int?[] FinancialYearId { get; set; }
        public int?[] Employeeid { get; set; }
        public int?[] BscPerspectiveTypeId { get; set; }
        public int?[] AppraisalReasonId { get; set; }
        public int?[] MeasurementMetricId { get; set; }
        public int?[] BSCKPIId { get; set; }
        public int?[] GenderId { get; set; }
        public string? Response { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? finYrId { get; set; }
    }
}
