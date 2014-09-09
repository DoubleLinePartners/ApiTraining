using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class StudentAcademicRecord {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A reference to the related EducationOrganization resource. */
    public EducationOrganizationReference educationOrganizationReference { get; set; }

    /* A reference to the related SchoolYearType resource. */
    public SchoolYearTypeReference schoolYearTypeReference { get; set; }

    /* A reference to the related Student resource. */
    public StudentReference studentReference { get; set; }

    /* The term for the session during the school year. */
    public string termType { get; set; }

    /* Key for Credit */
    public string cumulativeEarnedCreditType { get; set; }

    /* Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. */
    public double? cumulativeEarnedCreditConversion { get; set; }

    /* The cumulative number of credits an individual earns by completing courses or examinations during his or her enrollment in the current school as well as those credits transferred from schools in which the individual had been previously enrolled. */
    public double? cumulativeEarnedCredit { get; set; }

    /* Key for Credit */
    public string cumulativeAttemptedCreditType { get; set; }

    /* Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. */
    public double? cumulativeAttemptedCreditConversion { get; set; }

    /* The cumulative number of credits an individual attempts to earn by taking courses during his or her enrollment in the current school as well as those credits transferred from schools in which the individual had been previously enrolled. */
    public double? cumulativeAttemptedCredit { get; set; }

    /* The cumulative number of grade points an individual earns by successfully completing courses or examinations during his or her enrollment in the current school as well as those transferred from schools in which the individual had been previously enrolled. */
    public double? cumulativeGradePointsEarned { get; set; }

    /* A measure of average performance in all courses taken by an individual during his or her school career as determined for record-keeping purposes. This is obtained by dividing the total grade points received by the total number of credits attempted. This usually includes grade points received and credits attempted in his or her current school as well as those transferred from schools in which the individual was previously enrolled. */
    public double? cumulativeGradePointAverage { get; set; }

    /* The scale of equivalents, if applicable, for grades awarded as indicators of performance in schoolwork. For example, numerical equivalents for letter grades used in determining a student&apos;s Grade Point Average (A=4, B=3, C=2, D=1 in a four-point system) or letter equivalents for percentage grades (90-100%=A, 80-90%=B, etc.). */
    public string gradeValueQualifier { get; set; }

    /* The month and year the student is projected to graduate. */
    public DateTime? projectedGraduationDate { get; set; }

    /* Key for Credit */
    public string sessionEarnedCreditType { get; set; }

    /* Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. */
    public double? sessionEarnedCreditConversion { get; set; }

    /* The number of an credits an individual earned in this session. */
    public double? sessionEarnedCredit { get; set; }

    /* Key for Credit */
    public string sessionAttemptedCreditType { get; set; }

    /* Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. */
    public double? sessionAttemptedCreditConversion { get; set; }

    /* The number of an credits an individual attempted to earn in this session. */
    public double? sessionAttemptedCredit { get; set; }

    /* The number of grade points an individual earned for this session. */
    public double? sessionGradePointsEarned { get; set; }

    /* The grade point average for an individual computed as the grade points earned during the session divided by the number of credits attempted. */
    public double? sessionGradePointAverage { get; set; }

    /* This educational entity represents the cumulative record of academic achievement for a student. */
    public StudentAcademicRecordClassRanking classRanking { get; set; }

    /* An unordered collection of studentAcademicRecordAcademicHonors.  This educational entity represents the cumulative record of academic achievement for a student. */
    public List<StudentAcademicRecordAcademicHonor> academicHonors { get; set; }

    /* An unordered collection of studentAcademicRecordDiplomas.  This educational entity represents the cumulative record of academic achievement for a student. */
    public List<StudentAcademicRecordDiploma> diplomas { get; set; }

    /* An unordered collection of studentAcademicRecordRecognitions.  This educational entity represents the cumulative record of academic achievement for a student. */
    public List<StudentAcademicRecordRecognition> recognitions { get; set; }

    /* An unordered collection of studentAcademicRecordReportCards.  This educational entity represents the cumulative record of academic achievement for a student. */
    public List<StudentAcademicRecordReportCard> reportCards { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
