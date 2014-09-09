using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class DisciplineIncidentReference {
    /* School Identity Column */
    public int? schoolId { get; set; }

    /* A locally assigned unique identifier (within the school or school district) to identify each specific incident or occurrence. The same identifier should be used to document the entire incident even if it included multiple offenses and multiple offenders.   */
    public string incidentIdentifier { get; set; }

    /* Represents a hyperlink to the related disciplineIncident resource. */
    public Link link { get; set; }

    }
}
