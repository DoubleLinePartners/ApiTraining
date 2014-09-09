using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class BellScheduleMeetingTime {
    /* A reference to the related ClassPeriod resource. */
    public ClassPeriodReference classPeriodReference { get; set; }

    /*  */
    public string startTime { get; set; }

    /*  */
    public string endTime { get; set; }

    /*  */
    public string alternateDayName { get; set; }

    /*  */
    public bool? officialAttendancePeriod { get; set; }

    }
}
