namespace HCMIS.Model
{
    public class PrimaryDataModel
    {
    }
       
    
    public class HierarchicalDetails
    {
        public string Id { get; set; }
        public string FilllColor { get; set; }
        public string Border { get; set; }
        public string Label { get; set; }
        public List<string> ReportingPerson { get; set; }
    }
    //public partial class ViewJobDescriptionOpening
    //{
    //    public int JobDescriptionId { get; set; }
    //    public int? DepartmentId { get; set; }
    //    public string? DepartmentDescription { get; set; }
    //    public int? JibTitleId { get; set; }
    //    public string? JobTitleDescription { get; set; }
    //}
    //public partial class JobOpening
    //{
    //    public int JobOpeningId { get; set; }
    //    public int? JobDescriptionId { get; set; }
    //    public string? ReferenceNumber { get; set; }
    //    public DateTime? ApplicationOpeningDate { get; set; }
    //    public DateTime? ApplicationClosingDate { get; set; }
    //    public DateTime? CreationDate { get; set; }
    //    public string? CreatedBy { get; set; }
    //}
}
