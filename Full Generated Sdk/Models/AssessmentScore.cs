using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class AssessmentScore {
    /* Key for AssessmentReportingMethod */
    public string assessmentReportingMethodType { get; set; }

    /* The minimum score possible on the assessment. */
    public string minimumScore { get; set; }

    /* The maximum score possible on the assessment. */
    public string maximumScore { get; set; }

    /* A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. */
    public string resultDatatypeType { get; set; }

    }
}
