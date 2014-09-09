using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class EducationContentReference {
    /* A unique identifier for the content. */
    public string contentIdentifier { get; set; }

    /* Represents a hyperlink to the related educationContent resource. */
    public Link link { get; set; }

    }
}
