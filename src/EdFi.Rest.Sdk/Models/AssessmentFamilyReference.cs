using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class AssessmentFamilyReference {
    /* The title or name of the assessment family. */
    public string title { get; set; }

    /* Represents a hyperlink to the related assessmentFamily resource. */
    public Link link { get; set; }

    }
}
