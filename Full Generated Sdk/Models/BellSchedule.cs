using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class BellSchedule {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A reference to the related CalendarDate resource. */
    public CalendarDateReference calendarDateReference { get; set; }

    /* A reference to the related School resource. */
    public SchoolReference schoolReference { get; set; }

    /* Key for GradeLevel */
    public string gradeLevelDescriptor { get; set; }

    /* Name or title of the bell schedule. */
    public string name { get; set; }

    /* An unordered collection of bellScheduleMeetingTimes.  This entity represents the schedule of class period meeting times. */
    public List<BellScheduleMeetingTime> meetingTimes { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
