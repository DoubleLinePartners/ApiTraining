using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class StudentAssessmentItem {
    /* A reference to the related AssessmentItem resource. */
    public AssessmentItemReference assessmentItemReference { get; set; }

    /* A student's response to a stimulus on a test. */
    public string assessmentResponse { get; set; }

    /* Indicator of the response.  For example:  Nonscorable response  Ineffective response  Effective response  Partial response  ... */
    public string responseIndicatorType { get; set; }

    /* The analyzed result of a student''s response to an assessment item.. For example:  Correct  Incorrect  Met standard  ... */
    public string assessmentItemResultType { get; set; }

    /* A meaningful raw score of the performance of an individual on a test assessment item.  NEDM: Score Results */
    public int? rawScoreResult { get; set; }

    /* The overall time a student actually spent during the assessment item. */
    public string timeAssessed { get; set; }

    /* The description of the descriptor. */
    public string descriptiveFeedback { get; set; }

    }
}
