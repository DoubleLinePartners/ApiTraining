using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class EducationOrganizationReference {
    /* EducationOrganization Identity Column */
    public int? educationOrganizationId { get; set; }

    /* Represents a hyperlink to the related educationOrganization resource. */
    public Link link { get; set; }

    }
}
