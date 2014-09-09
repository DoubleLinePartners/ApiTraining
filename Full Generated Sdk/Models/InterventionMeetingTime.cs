using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class InterventionMeetingTime {
    /* A reference to the related ClassPeriod resource. */
    public ClassPeriodReference classPeriodReference { get; set; }

    /* An alternate name for the day (e.g., Red, Blue) */
    public string alternateDayName { get; set; }

    /* An indication of the time of day the class begins  NEDM: Class Beginning Time */
    public string startTime { get; set; }

    /* An indication of the time of day the class ends.  NEDM: Class Ending Time */
    public string endTime { get; set; }

    /* Indicator of whether this meeting time is used for official daily attendance. */
    public bool? officialAttendancePeriod { get; set; }

    }
}
