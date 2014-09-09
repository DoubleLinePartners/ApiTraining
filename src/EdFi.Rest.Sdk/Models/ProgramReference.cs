using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class ProgramReference {
    /* EducationOrganization Identity Column */
    public int? educationOrganizationId { get; set; }

    /* Key for Program */
    public string type { get; set; }

    /* The formal name of the program of instruction, training, services or benefits available through federal, state, or local agencies. */
    public string name { get; set; }

    /* Represents a hyperlink to the related program resource. */
    public Link link { get; set; }

    }
}
