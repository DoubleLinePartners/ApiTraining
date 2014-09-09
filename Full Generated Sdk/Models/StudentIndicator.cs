using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class StudentIndicator {
    /* The name of the indicator or metric. */
    public string indicatorName { get; set; }

    /* The value of the indicator or metric. */
    public string indicator { get; set; }

    /* The name for a group of indicators. */
    public string indicatorGroup { get; set; }

    /* The date when the indicator was assigned or computed. */
    public DateTime? beginDate { get; set; }

    /* The date the indicator or metric was sunset or removed. */
    public DateTime? endDate { get; set; }

    /* The person, organization, or department that designated the program association. */
    public string designatedBy { get; set; }

    }
}
