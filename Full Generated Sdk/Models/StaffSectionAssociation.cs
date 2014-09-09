using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class StaffSectionAssociation {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A reference to the related Section resource. */
    public SectionReference sectionReference { get; set; }

    /* A reference to the related Staff resource. */
    public StaffReference staffReference { get; set; }

    /* A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. */
    public string classroomPositionDescriptor { get; set; }

    /* Month, day and year of a teacher''s assignment to the section.  If blank, defaults to the first day of the first grading period for the section.     */
    public DateTime? beginDate { get; set; }

    /* Month, day and year of the last day of a teacher''s assignment to the section.  NEDM: Ending Date   */
    public DateTime? endDate { get; set; }

    /* An indication of whether a teacher is classified as highly qualified for his/her assignment according to state definition.  This attribute indicates the teacher is highly qualified for this section being taught.   */
    public bool? highlyQualifiedTeacher { get; set; }

    /*  */
    public bool? teacherStudentDataLinkExclusion { get; set; }

    /*  */
    public double? percentageContribution { get; set; }

    /*  */
    public string federallyFundedIndicator { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
