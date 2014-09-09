using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class SchoolCalendarDate {
    /*  */
    public string calendarEventDescriptor { get; set; }

    /*  */
    public DateTime? date { get; set; }

    /*  */
    public double? eventDuration { get; set; }

    /*  */
    public bool? instructionalDay { get; set; }

    }
}
