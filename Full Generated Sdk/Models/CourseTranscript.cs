using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class CourseTranscript {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A reference to the related StudentAcademicRecord resource. */
    public StudentAcademicRecordReference studentAcademicRecordReference { get; set; }

    /* The Education Organization that provided the reported instruction. */
    public int? courseEducationOrganizationId { get; set; }

    /* TThe actual code that identifies the organization of subject matter and related learning experiences provided for the instruction of students.   */
    public string courseCode { get; set; }

    /* The result from the student''s attempt to take the course, for example:  Pass  Fail  Incomplete  Withdrawn  Expelled   */
    public string courseAttemptResultType { get; set; }

    /* Key for Credit */
    public string attemptedCreditType { get; set; }

    /* Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. */
    public double? attemptedCreditConversion { get; set; }

    /* The number of credits attempted for a course.   */
    public double? attemptedCredit { get; set; }

    /* Key for Credit */
    public string earnedCreditType { get; set; }

    /* Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. */
    public double? earnedCreditConversion { get; set; }

    /* The number of credits awarded or earned for the course.   */
    public double? earnedCredit { get; set; }

    /* Student''s grade level at time of course.   */
    public string gradeLevelDescriptor { get; set; }

    /* The method the credits were earned, for example:  Classroom, Examination, Transfer   */
    public string methodCreditEarnedType { get; set; }

    /* The final letter grade earned for the course.   */
    public string finalLetterGradeEarned { get; set; }

    /* The final numeric grade earned for the course.   */
    public int? finalNumericGradeEarned { get; set; }

    /* Indicates that an academic course has been repeated by a student and how that repeat is to be computed in the student''s academic grade average.   */
    public string courseRepeatCodeType { get; set; }

    /*  */
    public int? schoolId { get; set; }

    /*  */
    public string courseTitle { get; set; }

    /*  */
    public string localCourseCode { get; set; }

    /*  */
    public string localCourseTitle { get; set; }

    /*  */
    public string privateOrOutOfStateIndicator { get; set; }

    /*  */
    public int? rigorPoints { get; set; }

    /* An unordered collection of courseTranscriptAdditionalCredits.  This entity is the final record of a student's performance in their courses at the end of a semester or school year. */
    public List<CourseTranscriptAdditionalCredit> additionalCredits { get; set; }

    /* An unordered collection of courseTranscriptExternalCourses.  This entity is the final record of a student's performance in their courses at the end of a semester or school year. */
    public List<CourseTranscriptExternalCourse> externalCourses { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
