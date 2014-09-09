using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class LearningStandardReference {
    /* The Identifier for the specific learning standard (e.g., 111.15.3.1.A) */
    public string learningStandardId { get; set; }

    /* Represents a hyperlink to the related learningStandard resource. */
    public Link link { get; set; }

    }
}
