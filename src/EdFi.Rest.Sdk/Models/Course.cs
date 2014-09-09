using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class Course {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A reference to the related EducationOrganization resource. */
    public EducationOrganizationReference educationOrganizationReference { get; set; }

    /* TThe actual code that identifies the organization of subject matter and related learning experiences provided for the instruction of students.   */
    public string code { get; set; }

    /* The descriptive name given to a course of study offered in a school or other institution or organization. In departmentalized classes at the elementary, secondary, and postsecondary levels (and for staff development activities), this refers to the name by which a course is identified (e.g., American History, English III). For elementary and other non-departmentalized classes, it refers to any portion of the instruction for which a grade or report is assigned (e.g., reading, composition, spelling, and language arts).   */
    public string title { get; set; }

    /* The number of parts identified for a course.   */
    public int? numberOfParts { get; set; }

    /* The intended major subject area of the course.  NEDM: Secondary Course Subject Area   */
    public string academicSubjectDescriptor { get; set; }

    /* A description of the content standards and goals covered in the course. Reference may be made to state or national content standards.  NEDM: Course Description   */
    public string description { get; set; }

    /* The date the district adopted the course.   */
    public DateTime? dateCourseAdopted { get; set; }

    /* An indication that this course credit is required for a high school diploma.   */
    public bool? highSchoolCourseRequirement { get; set; }

    /* An indicator of whether or not this course being described is included in the computation of the student&rsquo;s Grade Point Average, and if so, if it weighted differently from regular courses.   */
    public string gpaApplicabilityType { get; set; }

    /* Key for CourseDefinedByType. */
    public string definedByType { get; set; }

    /* Key for Credit */
    public string minimumAvailableCreditType { get; set; }

    /* Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. */
    public double? minimumAvailableCreditConversion { get; set; }

    /* The minimum amount of credit available to a student who successfully completes the course */
    public double? minimumAvailableCredit { get; set; }

    /* Key for Credit */
    public string maximumAvailableCreditType { get; set; }

    /* Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. */
    public double? maximumAvailableCreditConversion { get; set; }

    /* The maximum amount of credit available to a student who successfully completes the course */
    public double? maximumAvailableCredit { get; set; }

    /* Key for CareerPathway */
    public string careerPathwayType { get; set; }

    /* The actual or estimated number of clock minutes required for class completion.  This number is especially important for career and technical education classes and may represent (in minutes) the clock hour requirement of the class. */
    public int? timeRequiredForCompletion { get; set; }

    /* An unordered collection of courseCompetencyLevels.  This educational entity represents the organization of subject matter and related learning experiences provided for the instruction of students on a regular or systematic basis. */
    public List<CourseCompetencyLevel> competencyLevels { get; set; }

    /* An unordered collection of courseGradeLevels.  This educational entity represents the organization of subject matter and related learning experiences provided for the instruction of students on a regular or systematic basis. */
    public List<CourseGradeLevel> gradeLevels { get; set; }

    /* An unordered collection of courseIdentificationCodes.  This educational entity represents the organization of subject matter and related learning experiences provided for the instruction of students on a regular or systematic basis. */
    public List<CourseIdentificationCode> identificationCodes { get; set; }

    /* An unordered collection of courseLearningObjectives.  This educational entity represents the organization of subject matter and related learning experiences provided for the instruction of students on a regular or systematic basis. */
    public List<CourseLearningObjective> learningObjectives { get; set; }

    /* An unordered collection of courseLearningStandards.  This educational entity represents the organization of subject matter and related learning experiences provided for the instruction of students on a regular or systematic basis. */
    public List<CourseLearningStandard> learningStandards { get; set; }

    /* An unordered collection of courseLevelCharacteristics.  This educational entity represents the organization of subject matter and related learning experiences provided for the instruction of students on a regular or systematic basis. */
    public List<CourseLevelCharacteristic> levelCharacteristics { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
