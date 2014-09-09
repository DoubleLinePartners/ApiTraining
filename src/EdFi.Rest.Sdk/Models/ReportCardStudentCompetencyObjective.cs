using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class ReportCardStudentCompetencyObjective {
    /* A reference to the related StudentCompetencyObjective resource. */
    public StudentCompetencyObjectiveReference studentCompetencyObjectiveReference { get; set; }

    /* EducationOrganization Identity Column */
    public int? objectiveEducationOrganizationId { get; set; }

    }
}
