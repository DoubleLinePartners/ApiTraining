using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class EducationServiceCenterReference {
    /* EducationServiceCenter Identity Column */
    public int? educationServiceCenterId { get; set; }

    /* Represents a hyperlink to the related educationServiceCenter resource. */
    public Link link { get; set; }

    }
}
