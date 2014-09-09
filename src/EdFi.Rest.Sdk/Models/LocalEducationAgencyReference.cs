using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class LocalEducationAgencyReference {
    /* EducationOrganization Identity Column */
    public int? localEducationAgencyId { get; set; }

    /* Represents a hyperlink to the related localEducationAgency resource. */
    public Link link { get; set; }

    }
}
