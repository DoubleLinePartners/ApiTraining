using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class StudentSectionAssociationReference {
    /* A unique alpha-numeric code assigned to a student. */
    public string studentUniqueId { get; set; }

    /* School Identity Column */
    public int? schoolId { get; set; }

    /* An indication of the portion of a typical daily session in which students receive instruction in a specified subject (e.g., morning, sixth period, block period, or AB schedules).   NEDM: Class Period   */
    public string classPeriodName { get; set; }

    /* A unique number or alphanumeric code assigned to a room by a school, school system, state, or other agency or entity.   */
    public string classroomIdentificationCode { get; set; }

    /* The local code assigned by the LEA or Campus that identifies the organization of subject matter and related learning experiences provided for the instruction of students.   */
    public string localCourseCode { get; set; }

    /* The name of the term in which the section is offered (e.g., First semester, Second semester, Year long, summer school)   */
    public string termType { get; set; }

    /* The identifier for the school year (e.g., 2010/11).   */
    public int? schoolYear { get; set; }

    /* Month, day and year of the student''s entry or assignment to the section.  If blank, default is the start date of the first grading period.  NEDM: EntryDate   */
    public DateTime? beginDate { get; set; }

    /* Represents a hyperlink to the related studentSectionAssociation resource. */
    public Link link { get; set; }

    }
}
