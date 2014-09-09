using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class SchoolCalendar {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A reference to the related DistrictCalendar resource. */
    public DistrictCalendarReference districtCalendarReference { get; set; }

    /* A reference to the related School resource. */
    public SchoolReference schoolReference { get; set; }

    /*  */
    public int? number { get; set; }

    /*  */
    public string instructionalCalendarDescriptor { get; set; }

    /*  */
    public int? stockpileProfessionalDevDays { get; set; }

    /*  */
    public int? instructionalDays { get; set; }

    /*  */
    public int? studentDay { get; set; }

    /*  */
    public int? teacherDay { get; set; }

    /*  */
    public string usesBlockScheduleIndicator { get; set; }

    /*  */
    public DateTime? springBlockBeginDate { get; set; }

    /* An unordered collection of schoolCalendarDates.   */
    public List<SchoolCalendarDate> dates { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
