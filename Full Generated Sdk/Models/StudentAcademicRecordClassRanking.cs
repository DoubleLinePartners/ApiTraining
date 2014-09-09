using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class StudentAcademicRecordClassRanking {
    /* The academic rank of a student in relation to his or her graduating class (e.g., 1st, 2nd, 3rd).   */
    public int? classRank { get; set; }

    /* The total number of students in the student''s graduating class.   */
    public int? totalNumberInClass { get; set; }

    /* The academic percentage rank of a student in relation to his or her graduating class (e.g., 95%, 80%, 50%).   */
    public int? percentageRanking { get; set; }

    /* Date class ranking was determined.   */
    public DateTime? classRankingDate { get; set; }

    }
}
