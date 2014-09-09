using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class StudentAssessmentStudentObjectiveAssessment {
    /* A reference to the related ObjectiveAssessment resource. */
    public ObjectiveAssessmentReference objectiveAssessmentReference { get; set; }

    /* An unordered collection of studentAssessmentStudentObjectiveAssessmentPerformanceLevels.  This entity holds the score and or performance levels earned for an objective assessment by a student. */
    public List<StudentAssessmentStudentObjectiveAssessmentPerformanceLevel> performanceLevels { get; set; }

    /* An unordered collection of studentAssessmentStudentObjectiveAssessmentScoreResults.  This entity holds the score and or performance levels earned for an objective assessment by a student. */
    public List<StudentAssessmentStudentObjectiveAssessmentScoreResult> scoreResults { get; set; }

    }
}
