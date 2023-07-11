using System;
using System.Collections.Generic;

namespace HCMIS.Model
{
    public partial class ADifficultyLevel
    {
        public ADifficultyLevel()
        {
            AptituddeTestQuestions = new HashSet<AptituddeTestQuestions>();
        }

        public int DifficultyLevelId { get; set; }
        public string? DifficultyLevelDesc { get; set; }

        public virtual ICollection<AptituddeTestQuestions> AptituddeTestQuestions { get; set; }
    }
}
