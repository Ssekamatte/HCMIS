namespace HCMIS.Model.JobDescriptionModel
{
    public class JobDescription
    {
        public int JobDescriptionId { get; set; }
        public int? JibTitleId { get; set; }
        public int? DepartmentId { get; set; }
        public int? SalaryScaleId { get; set; }
        /// <summary>
        /// This column will contain extra description of the given job description
        /// </summary>
        public string? JobDescription1 { get; set; }
        /// <summary>
        /// This Column is the primary key for the job types and it will be auto incremented whenever a new job type is added
        /// </summary>
        public int? JobTypeId { get; set; }
        public int? ContractLength { get; set; }
        public int? ContractLengthTypeId { get; set; }
        public DateTime? ContractStartDate { get; set; }
        public DateTime? ContractEnddate { get; set; }
        /// <summary>
        /// This column will store the minimum Years of experience Required for the specific job description
        /// </summary>
        public double? MinimumYearsofExperience { get; set; }
        public int? Vacancies { get; set; }
        public int? MinimumLevelOfEducationId { get; set; }
        /// <summary>
        /// This column will store the Jobstatusid of the Jobstatus that will be mapped to this job description and it will reference the A_JobStatus Table
        /// </summary>
        public int? JobStatusId { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
