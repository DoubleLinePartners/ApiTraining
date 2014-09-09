using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class GradeReference {
    /* A unique alpha-numeric code assigned to a student. */
    public string studentUniqueId { get; set; }

    /* School Identity Column */
    public int? schoolId { get; set; }

    /* An indication of the portion of a typical daily session in which students receive instruction in a specified subject (e.g., morning, sixth period, block period, or AB schedules).  NEDM: Class Period */
    public string classPeriodName { get; set; }

    /* A unique number or alphanumeric code assigned to a room by a school, school system, state, or other agency or entity. */
    public string classroomIdentificationCode { get; set; }

    /* The local code assigned by the LEA or Campus that identifies the organization of subject matter and related learning experiences provided for the instruction of students. */
    public string localCourseCode { get; set; }

    /* The name of the term in which the section is offered (e.g., First semester, Second semester, Year long, summer school) */
    public string termType { get; set; }

    /* The identifier for the school year (e.g., 2010/11). */
    public int? schoolYear { get; set; }

    /* Month, day and year of the student's entry or assignment to the section. */
    public DateTime? beginDate { get; set; }

    /* The name of the grading period during the school year in which the grade is offered (e.g., 1st cycle, 1st semester) */
    public string gradingPeriodDescriptor { get; set; }

    /* Month, day, and year of the first day of the grading period. */
    public DateTime? gradingPeriodBeginDate { get; set; }

    /* The Education Organization that defines the grading period. */
    public int? gradingPeriodEducationOrganizationId { get; set; }

    /* The type of grade (e.g., Exam, Final, Grading Period, Progress Report) */
    public string type { get; set; }

    /* Represents a hyperlink to the related grade resource. */
    public Link link { get; set; }

    }
}
