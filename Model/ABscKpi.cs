namespace HCMIS.Model
{
    public class ABscKpi
    {
        public int Bsckpiid { get; set; }
        public int? BscPerspectiveTypeId { get; set; }
        public string? Bsckpidescription { get; set; }
        public int? MeasurementMetricId { get; set; }
        public int? FinancialYearId { get; set; }
        public string? UserId { get; set; }
        public DateTime? DateAdded { get; set; }
        public double? IndividualTargetWeight { get; set; }

    }
}
