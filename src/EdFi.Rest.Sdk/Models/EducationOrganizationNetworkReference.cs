using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class EducationOrganizationNetworkReference {
    /* EducationOrganization Identity Column */
    public int? educationOrganizationNetworkId { get; set; }

    /* Represents a hyperlink to the related educationOrganizationNetwork resource. */
    public Link link { get; set; }

    }
}
