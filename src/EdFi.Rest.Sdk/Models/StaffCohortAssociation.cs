using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class StaffCohortAssociation {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A reference to the related Cohort resource. */
    public CohortReference cohortReference { get; set; }

    /* A reference to the related Staff resource. */
    public StaffReference staffReference { get; set; }

    /* The start date the staff was associated with the cohort.   */
    public DateTime? beginDate { get; set; }

    /* The end date of the staff association with the cohort.   */
    public DateTime? endDate { get; set; }

    /* Indicator of whether the staff has access to the student records of the cohort per district interpretation of FERPA and other privacy laws, regulations and policies.   */
    public bool? studentRecordAccess { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
