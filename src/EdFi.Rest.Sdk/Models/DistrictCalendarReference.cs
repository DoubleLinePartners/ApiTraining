using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class DistrictCalendarReference {
    /*  */
    public int? localEducationAgencyId { get; set; }

    /*  */
    public int? schoolYear { get; set; }

    /*  */
    public int? number { get; set; }

    /* Represents a hyperlink to the related districtCalendar resource. */
    public Link link { get; set; }

    }
}
