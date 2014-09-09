using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class StudentAssessmentStudentObjectiveAssessmentScoreResult {
    /* Key for AssessmentReportingMethod */
    public string assessmentReportingMethodType { get; set; }

    /* The value of a meaningful raw score or statistical expression of the performance of an individual. The results can be expressed as a number, percentile, range, level, etc. */
    public string result { get; set; }

    /* A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. */
    public string resultDatatypeType { get; set; }

    }
}
