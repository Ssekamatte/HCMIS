using System;
using System.Collections.Generic;

namespace HCMIS.Model
{
    public partial class AppliedForJobsComment
    {
        public int ApplicationProcessCommentId { get; set; }
        public int? AppliedForJobsId { get; set; }
        public string? CommentDesc { get; set; }
        public DateTime? CommentDate { get; set; }
        public string? CommentedBy { get; set; }

        public virtual AppliedForJobs? AppliedForJobs { get; set; }
    }
}
