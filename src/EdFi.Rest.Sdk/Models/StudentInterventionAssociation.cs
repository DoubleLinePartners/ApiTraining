using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class StudentInterventionAssociation {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A reference to the related Cohort resource. */
    public CohortReference cohortReference { get; set; }

    /* A reference to the related Intervention resource. */
    public InterventionReference interventionReference { get; set; }

    /* A reference to the related Student resource. */
    public StudentReference studentReference { get; set; }

    /* EducationOrganization Identity Column */
    public int? cohortEducationOrganizationId { get; set; }

    /* The description of the descriptor. */
    public string diagnosticStatement { get; set; }

    /* An unordered collection of studentInterventionAssociationInterventionEffectivenesses.  This association indicates the students participating in an intervention. */
    public List<StudentInterventionAssociationInterventionEffectiveness> interventionEffectivenesses { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
