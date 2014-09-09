using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class AcademicWeekReference {
    /* The campus label for the week.   */
    public string weekIdentifier { get; set; }

    /* EducationOrganization Identity Column */
    public int? educationOrganizationId { get; set; }

    /* Represents a hyperlink to the related academicWeek resource. */
    public Link link { get; set; }

    }
}
