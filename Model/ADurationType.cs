using System;
using System.Collections.Generic;

namespace HCMIS.Model
{
    public partial class ADurationType
    {
        public ADurationType()
        {
            AptituddeTestHeader = new HashSet<AptituddeTestHeader>();
        }

        public int DurationTypeId { get; set; }
        public string? DurationTypeDesc { get; set; }

        public virtual ICollection<AptituddeTestHeader> AptituddeTestHeader { get; set; }
    }
}
