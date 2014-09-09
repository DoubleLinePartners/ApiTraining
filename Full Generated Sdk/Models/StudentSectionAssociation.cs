using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class StudentSectionAssociation {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A reference to the related Section resource. */
    public SectionReference sectionReference { get; set; }

    /* A reference to the related Student resource. */
    public StudentReference studentReference { get; set; }

    /* Month, day and year of the student''s entry or assignment to the section.  If blank, default is the start date of the first grading period.  NEDM: EntryDate   */
    public DateTime? beginDate { get; set; }

    /* Month, day, and year of the withdrawal or exit of the student from the section.  NEDM: Exit/Withdraw Date   */
    public DateTime? endDate { get; set; }

    /* Indicator that the class is the student''s designated homeroom used for daily attendance reporting.   */
    public bool? homeroomIndicator { get; set; }

    /* An indication as to whether a student has previously taken a given course.  NEDM: Repeat Identifier  Repeated, counted in grade point average  Repeated, not counted in grade point average  Not repeated  Other   */
    public string repeatIdentifierType { get; set; }

    /* Indicates that the student-section combination is excluded from calculation of value-added or growth attribution calculations used for a particular teacher evaluation. */
    public bool? teacherStudentDataLinkExclusion { get; set; }

    /*  */
    public string vocationalOutsideIEPIndicator { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
