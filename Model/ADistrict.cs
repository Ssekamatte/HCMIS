using System;
using System.Collections.Generic;

namespace HCMIS.Models
{
    public partial class ADistrict
    {
        public int DistrictId { get; set; }
        public string? DistrictDescription { get; set; }
        public int? CountryId { get; set; }
    }
}
