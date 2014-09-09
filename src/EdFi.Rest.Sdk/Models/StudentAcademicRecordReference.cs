using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class StudentAcademicRecordReference {
    /* A unique alpha-numeric code assigned to a student. */
    public string studentUniqueId { get; set; }

    /* EducationOrganization Identity Column */
    public int? educationOrganizationId { get; set; }

    /* The identifier for the school year. */
    public int? schoolYear { get; set; }

    /* The term for the session during the school year. */
    public string termType { get; set; }

    /* Represents a hyperlink to the related studentAcademicRecord resource. */
    public Link link { get; set; }

    }
}
