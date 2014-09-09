using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class StaffLanguage {
    /* A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. */
    public string languageDescriptor { get; set; }

    /* An unordered collection of staffLanguageUses.  Language(s) the individual uses to communicate. */
    public List<StaffLanguageUse> uses { get; set; }

    }
}
