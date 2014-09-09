using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class GradingPeriod {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A reference to the related CalendarDate resource. */
    public CalendarDateReference beginCalendarDateReference { get; set; }

    /* A reference to the related CalendarDate resource. */
    public CalendarDateReference endCalendarDateReference { get; set; }

    /* The name of the grading period during the school year in which the grade is offered (e.g., 1st cycle, 1st semester)   */
    public string descriptor { get; set; }

    /* Total days available for educational instruction during the grading period.   */
    public int? totalInstructionalDays { get; set; }

    /* The sequential order of this period relative to other periods. */
    public int? periodSequence { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
