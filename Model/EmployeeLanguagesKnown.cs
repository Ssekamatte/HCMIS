using HCMIS.Model;
using HCMIS.SHARED;
using System;
using System.Collections.Generic;

namespace HCMIS.Model
{
    public partial class EmployeeLanguagesKnown
    {
        public int LanguagesKnownId { get; set; }
        public int Employeeid { get; set; }
        public int LanguageId { get; set; }
        public int? LanguageProlificId { get; set; }

        public virtual EmployeeDto Employee { get; set; } = null!;
        public virtual ALanguages? LanguageProlific { get; set; }
        public virtual ALanguageProlific? LanguageProlificNavigation { get; set; }
    }
}
