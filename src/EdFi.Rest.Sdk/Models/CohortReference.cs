using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class CohortReference {
    /* EducationOrganization Identity Column */
    public int? educationOrganizationId { get; set; }

    /* The name or ID for the cohort.   */
    public string identifier { get; set; }

    /* Represents a hyperlink to the related cohort resource. */
    public Link link { get; set; }

    }
}
