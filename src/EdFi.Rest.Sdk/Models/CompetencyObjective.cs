using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class CompetencyObjective {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A reference to the related EducationOrganization resource. */
    public EducationOrganizationReference educationOrganizationReference { get; set; }

    /* The designated title of the competency objective. */
    public string objective { get; set; }

    /* The grade level for which the competency objective is targeted, */
    public string objectiveGradeLevelDescriptor { get; set; }

    /* The identifier of the competency objective. */
    public string competencyObjectiveId { get; set; }

    /* The description of the competency objective. */
    public string description { get; set; }

    /*  */
    public string successCriteria { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
