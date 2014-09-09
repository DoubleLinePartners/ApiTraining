using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class StudentSectionAttendanceEvent {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A reference to the related Section resource. */
    public SectionReference sectionReference { get; set; }

    /* A reference to the related Student resource. */
    public StudentReference studentReference { get; set; }

    /* Date for this attendance event.   */
    public DateTime? eventDate { get; set; }

    /* A code describing the type of the attendance event.  In Attendance  Absence  Excused Absence  Unexcused Absence  Tardy  Early departure  NEDM: Attendance Event Category   */
    public string attendanceEventCategoryDescriptor { get; set; }

    /* The reason for the absence or tardy.   */
    public string attendanceEventReason { get; set; }

    /* The setting in which a child receives education and related services.  This is only used in the AttendanceEvent if different from that in the related Section.   */
    public string educationalEnvironmentType { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
