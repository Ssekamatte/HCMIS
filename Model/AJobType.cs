namespace HCMIS.Model
{
    public class AJobType
    {
        /// <summary>
        /// This Column is the primary key for the job types and it will be auto incremented whenever a new job type is added
        /// </summary>
        public int JobTypeId { get; set; }
        /// <summary>
        /// This column will handle the description of the type of job that will be displayed in the dropdowns and other parts in the system
        /// </summary>
        public string? TypeDescription { get; set; }
    }
}
