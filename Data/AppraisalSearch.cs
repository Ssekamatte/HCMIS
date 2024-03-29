﻿namespace HCMIS.Data
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
        public int?[] YearId { get; set; }

        public int?[] ShortlistId { get; set; }
        public int?[] DepartmentId { get; set; }

        public string? ReferenceNumber { get; set; }

        public int?[] JobTitleId { get; set; }
    }
}
