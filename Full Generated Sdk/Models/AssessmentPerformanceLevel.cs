using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class AssessmentPerformanceLevel {
    /* The performance level(s) defined for the assessment. */
    public string performanceLevelDescriptor { get; set; }

    /* Key for AssessmentReportingMethod */
    public string assessmentReportingMethodType { get; set; }

    /* The minimum score required to make the indicated level of performance. */
    public string minimumScore { get; set; }

    /* The maximum score to make the indicated level of performance. */
    public string maximumScore { get; set; }

    /* A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. */
    public string resultDatatypeType { get; set; }

    }
}
