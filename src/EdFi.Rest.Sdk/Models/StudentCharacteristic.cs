using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class StudentCharacteristic {
    /* The characteristic designated for the student. */
    public string descriptor { get; set; }

    /* The date the characteristic was designated. */
    public DateTime? beginDate { get; set; }

    /* The date the characteristic was removed. */
    public DateTime? endDate { get; set; }

    /* The person, organization, or department that designated the characteristic. */
    public string designatedBy { get; set; }

    }
}
