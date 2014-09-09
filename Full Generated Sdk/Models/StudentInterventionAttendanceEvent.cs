using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class StudentInterventionAttendanceEvent {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A reference to the related Intervention resource. */
    public InterventionReference interventionReference { get; set; }

    /* A reference to the related Student resource. */
    public StudentReference studentReference { get; set; }

    /* Date for this attendance event. */
    public DateTime? eventDate { get; set; }

    /* Key for AttendanceEventCategoryType */
    public string attendanceEventCategoryDescriptor { get; set; }

    /* The reported reason for a student's absence. */
    public string attendanceEventReason { get; set; }

    /* Key for EducationalEnvironment */
    public string educationalEnvironmentType { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
