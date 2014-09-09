using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class SchoolCalendarReference {
    /*  */
    public int? localEducationAgencyId { get; set; }

    /*  */
    public int? schoolYear { get; set; }

    /*  */
    public int? districtCalendarNumber { get; set; }

    /*  */
    public int? schoolId { get; set; }

    /*  */
    public int? number { get; set; }

    /* Represents a hyperlink to the related schoolCalendar resource. */
    public Link link { get; set; }

    }
}
