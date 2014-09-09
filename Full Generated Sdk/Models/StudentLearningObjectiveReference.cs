using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class StudentLearningObjectiveReference {
    /* A unique alpha-numeric code assigned to a student. */
    public string studentUniqueId { get; set; }

    /*  */
    public int? gradingPeriodEducationOrganizationId { get; set; }

    /*  */
    public string gradingPeriodDescriptor { get; set; }

    /*  */
    public DateTime? gradingPeriodBeginDate { get; set; }

    /* The designated title of the learning objective. */
    public string objective { get; set; }

    /* The description of the content or subject area (e.g., arts, mathematics, reading, stenography, or a foreign language) of an assessment. */
    public string academicSubjectDescriptor { get; set; }

    /* The grade level for which the learning objective is targeted, */
    public string objectiveGradeLevelDescriptor { get; set; }

    /* Represents a hyperlink to the related studentLearningObjective resource. */
    public Link link { get; set; }

    }
}
