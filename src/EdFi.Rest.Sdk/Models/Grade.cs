using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class Grade {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A reference to the related GradingPeriod resource. */
    public GradingPeriodReference gradingPeriodReference { get; set; }

    /* A reference to the related StudentSectionAssociation resource. */
    public StudentSectionAssociationReference studentSectionAssociationReference { get; set; }

    /* The type of grade (e.g., Exam, Final, Grading Period, Progress Report) */
    public string type { get; set; }

    /* A final or interim (grading period) indicator of student performance in a class as submitted by the instructor. */
    public string letterGradeEarned { get; set; }

    /* A final or interim (grading period) indicator of student performance in a class as submitted by the instructor. */
    public int? numericGradeEarned { get; set; }

    /* A statement provided by the teacher that provides information in addition to the grade or assessment score. */
    public string diagnosticStatement { get; set; }

    /* The performance base conversion assessed for the student. */
    public string performanceBaseConversionType { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
