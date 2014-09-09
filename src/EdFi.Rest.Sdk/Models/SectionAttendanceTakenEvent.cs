using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class SectionAttendanceTakenEvent {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A reference to the related CalendarDate resource. */
    public CalendarDateReference calendarDateReference { get; set; }

    /* A reference to the related Section resource. */
    public SectionReference sectionReference { get; set; }

    /* A reference to the related Staff resource. */
    public StaffReference staffReference { get; set; }

    /*  */
    public DateTime? eventDate { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
