using System;
using System.Collections.Generic;

namespace HCMIS.Model
{
    public partial class APublicHolidays
    {
        public int HolidayId { get; set; }
        public DateTime? HolidayDate { get; set; }
        public string? HolidayName { get; set; }
        public int? Day { get; set; }
        public int? Year { get; set; }
        public int? Month { get; set; }
        public bool? ReoccursSameDate { get; set; }
        public bool? IsBlock { get; set; }
        public bool? IsAllDay { get; set; }
    }
}
