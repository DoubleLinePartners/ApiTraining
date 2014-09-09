using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class CalendarDateReference {
    /* EducationOrganization Identity Column */
    public int? educationOrganizationId { get; set; }

    /* Month, day, and year of the first day of the grading period.     */
    public DateTime? date { get; set; }

    /* Represents a hyperlink to the related calendarDate resource. */
    public Link link { get; set; }

    }
}
