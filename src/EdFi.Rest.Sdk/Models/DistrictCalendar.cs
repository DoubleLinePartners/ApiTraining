using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class DistrictCalendar {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A reference to the related LocalEducationAgency resource. */
    public LocalEducationAgencyReference localEducationAgencyReference { get; set; }

    /* A reference to the related SchoolYearType resource. */
    public SchoolYearTypeReference schoolYearTypeReference { get; set; }

    /*  */
    public int? number { get; set; }

    /*  */
    public string scheduledDaysDescriptor { get; set; }

    /*  */
    public string instructionalCalendarDescriptor { get; set; }

    /*  */
    public int? stockpileInclementWeatherDays { get; set; }

    /*  */
    public int? stockpileProfessionalDevDays { get; set; }

    /*  */
    public double? inServiceDays { get; set; }

    /*  */
    public double? optionalInServiceDays { get; set; }

    /*  */
    public int? parentTeacherConferenceDays { get; set; }

    /*  */
    public int? teacherVacationDays { get; set; }

    /*  */
    public int? abbreviatedDays { get; set; }

    /*  */
    public double? discretionaryTeacherVacationDays { get; set; }

    /*  */
    public double? discretionaryInServiceDays { get; set; }

    /*  */
    public double? discretionaryAdministrativeDays { get; set; }

    /*  */
    public double? discretionaryInstructionalDays { get; set; }

    /*  */
    public double? discretionaryOtherDays { get; set; }

    /*  */
    public int? instructionalDays { get; set; }

    /* An unordered collection of districtCalendarDates.   */
    public List<DistrictCalendarDate> dates { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
