using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class StudentDisciplineIncidentAssociationBehavior {
    /* The ID of the Behavior Descriptor */
    public string behaviorDescriptor { get; set; }

    /* Specifies a more granular level of detail of a behavior involved in the incident. */
    public string behaviorDetailedDescription { get; set; }

    }
}
