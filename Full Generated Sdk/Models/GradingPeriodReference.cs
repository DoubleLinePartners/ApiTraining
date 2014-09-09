using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class GradingPeriodReference {
    /* EducationOrganization Identity Column */
    public int? educationOrganizationId { get; set; }

    /* The name of the grading period during the school year in which the grade is offered (e.g., 1st cycle, 1st semester)   */
    public string descriptor { get; set; }

    /* Month, day, and year of the first day of the grading period.     */
    public DateTime? beginDate { get; set; }

    /* Represents a hyperlink to the related gradingPeriod resource. */
    public Link link { get; set; }

    }
}
