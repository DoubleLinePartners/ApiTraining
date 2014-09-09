using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class StudentCohortAssociation {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A reference to the related Cohort resource. */
    public CohortReference cohortReference { get; set; }

    /* A reference to the related Student resource. */
    public StudentReference studentReference { get; set; }

    /* The start date for assignment to this cohort.   */
    public DateTime? beginDate { get; set; }

    /* The end date for assignment to this cohort.   */
    public DateTime? endDate { get; set; }

    /* An unordered collection of studentCohortAssociationSections.  This association represents the cohort(s) for which a student is designated. */
    public List<StudentCohortAssociationSection> sections { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
