using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class StudentCompetencyObjectiveReference {
    /* A unique alpha-numeric code assigned to a student. */
    public string studentUniqueId { get; set; }

    /* EducationOrganization Identity Column */
    public int? gradingPeriodEducationOrganizationId { get; set; }

    /* The name of the grading period during the school year in which the grade is offered (e.g., 1st cycle, 1st semester) */
    public string gradingPeriodDescriptor { get; set; }

    /* Month, day, and year of the first day of the grading period. */
    public DateTime? gradingPeriodBeginDate { get; set; }

    /* The designated title of the learning objective. */
    public string objective { get; set; }

    /* The grade level for which the learning objective is targeted, */
    public string objectiveGradeLevelDescriptor { get; set; }

    /* EducationOrganization Identity Column */
    public int? objectiveEducationOrganizationId { get; set; }

    /* Represents a hyperlink to the related studentCompetencyObjective resource. */
    public Link link { get; set; }

    }
}
