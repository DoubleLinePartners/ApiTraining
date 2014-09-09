using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class LeaveEvent {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A reference to the related Staff resource. */
    public StaffReference staffReference { get; set; }

    /* Date for this leave event.   */
    public DateTime? eventDate { get; set; }

    /* The code describing the type of leave taken, for example:  Sick  Personal  Vacation   */
    public string categoryType { get; set; }

    /* Expanded reason for the staff leave.   */
    public string reason { get; set; }

    /* The hours the staff was absent, if not the entire working day.   */
    public double? hoursOnLeave { get; set; }

    /* Indicator of whether a substitute was assigned during the period of staff leave.   */
    public bool? substituteAssigned { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
