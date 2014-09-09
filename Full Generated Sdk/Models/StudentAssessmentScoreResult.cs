using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class StudentAssessmentScoreResult {
    /* The name of the analytic score.  For example:  Percentile  Quantile measure  Lexile measure  Vertical scale score  TPM score  ...  ...   */
    public string assessmentReportingMethodType { get; set; }

    /* Value for the analytic score.   */
    public string result { get; set; }

    /* A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. */
    public string resultDatatypeType { get; set; }

    }
}
