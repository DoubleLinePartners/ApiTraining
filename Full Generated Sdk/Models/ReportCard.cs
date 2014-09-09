using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class ReportCard {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A reference to the related GradingPeriod resource. */
    public GradingPeriodReference gradingPeriodReference { get; set; }

    /* A reference to the related Student resource. */
    public StudentReference studentReference { get; set; }

    /* EducationOrganization Identity Column */
    public int? educationOrganizationId { get; set; }

    /* A measure of average performance in all courses taken by an individual for the current grading period. */
    public double? gpaGivenGradingPeriod { get; set; }

    /* A measure of cumulative average performance in all courses taken by an individual from the beginning of the school year through the current grading period. */
    public double? gpaCumulative { get; set; }

    /* The number of days an individual is absent when school is in session during a given reporting period.  NEDM: Number of Days Absent */
    public double? numberOfDaysAbsent { get; set; }

    /* The number of days an individual is present when school is in session during a given reporting period.  NEDM: Number Of Days in Attendance */
    public double? numberOfDaysInAttendance { get; set; }

    /* The number of days an individual is tardy during a given reporting period. */
    public int? numberOfDaysTardy { get; set; }

    /* An unordered collection of reportCardGrades.  This educational entity represents the collection of student grades for courses taken during a grading period. */
    public List<ReportCardGrade> grades { get; set; }

    /* An unordered collection of reportCardStudentCompetencyObjectives.  This educational entity represents the collection of student grades for courses taken during a grading period. */
    public List<ReportCardStudentCompetencyObjective> studentCompetencyObjectives { get; set; }

    /* An unordered collection of reportCardStudentLearningObjectives.  This educational entity represents the collection of student grades for courses taken during a grading period. */
    public List<ReportCardStudentLearningObjective> studentLearningObjectives { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
