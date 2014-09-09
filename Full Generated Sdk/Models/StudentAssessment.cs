using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class StudentAssessment {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A reference to the related Assessment resource. */
    public AssessmentReference assessmentReference { get; set; }

    /* A reference to the related Student resource. */
    public StudentReference studentReference { get; set; }

    /* The month(s), day(s), and year on which an assessment is administered or first day of administration if over multiple days.  NEDM: Assessment Administration Date   */
    public DateTime? administrationDate { get; set; }

    /* Assessment Administration End Date, if administered over multiple days.   */
    public DateTime? administrationEndDate { get; set; }

    /* The unique number of the assessment form or answer document.   */
    public string serialNumber { get; set; }

    /* A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. */
    public string administrationLanguageDescriptor { get; set; }

    /* The environment in which the test was administered.  For example:  Electronic  Classroom  Testing Center  ...  ....   */
    public string administrationEnvironmentType { get; set; }

    /* Indicator if the test was retaken.  For example:  Primary administration  First retest  Second retest  ...   */
    public string retestIndicatorType { get; set; }

    /* The primary reason student is not tested. For example:  Absent  Refusal by parent  Refusal by student  Medical waiver  Illness  Disruptive behavior  LEP Exempt  ...   */
    public string reasonNotTestedType { get; set; }

    /* The grade level of a student when assessed.   */
    public string whenAssessedGradeLevelDescriptor { get; set; }

    /* A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. */
    public string eventCircumstanceType { get; set; }

    /* Describes special events that occur before during or after the assessment session that may impact use of results. */
    public string eventDescription { get; set; }

    /* An unordered collection of studentAssessmentAccommodations.  This entity represents the analysis or scoring of a student's response on an assessment. The analysis results in a value that represents a student's performance on a set of items on a test. */
    public List<StudentAssessmentAccommodation> accommodations { get; set; }

    /* An unordered collection of studentAssessmentItems.  This entity represents the analysis or scoring of a student's response on an assessment. The analysis results in a value that represents a student's performance on a set of items on a test. */
    public List<StudentAssessmentItem> items { get; set; }

    /* An unordered collection of studentAssessmentPerformanceLevels.  This entity represents the analysis or scoring of a student's response on an assessment. The analysis results in a value that represents a student's performance on a set of items on a test. */
    public List<StudentAssessmentPerformanceLevel> performanceLevels { get; set; }

    /* An unordered collection of studentAssessmentScoreResults.  This entity represents the analysis or scoring of a student's response on an assessment. The analysis results in a value that represents a student's performance on a set of items on a test. */
    public List<StudentAssessmentScoreResult> scoreResults { get; set; }

    /* An unordered collection of studentAssessmentStudentObjectiveAssessments.  This entity represents the analysis or scoring of a student's response on an assessment. The analysis results in a value that represents a student's performance on a set of items on a test. */
    public List<StudentAssessmentStudentObjectiveAssessment> studentObjectiveAssessments { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
