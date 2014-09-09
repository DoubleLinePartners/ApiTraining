using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class StudentStandardDay {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A reference to the related SchoolCalendar resource. */
    public SchoolCalendarReference schoolCalendarReference { get; set; }

    /*  */
    public string gradeLevelDescriptor { get; set; }

    /*  */
    public int? totalInstructionalMins { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
