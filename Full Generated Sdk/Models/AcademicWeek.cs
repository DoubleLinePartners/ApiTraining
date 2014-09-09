using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class AcademicWeek {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A reference to the related CalendarDate resource. */
    public CalendarDateReference beginCalendarDateReference { get; set; }

    /* A reference to the related CalendarDate resource. */
    public CalendarDateReference endCalendarDateReference { get; set; }

    /* The campus label for the week.   */
    public string weekIdentifier { get; set; }

    /* The total instructional days during the academic week.   */
    public int? totalInstructionalDays { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
