using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class StateEducationAgencyReference {
    /* StateEducationAgency Identity Column */
    public int? stateEducationAgencyId { get; set; }

    /* Represents a hyperlink to the related stateEducationAgency resource. */
    public Link link { get; set; }

    }
}
