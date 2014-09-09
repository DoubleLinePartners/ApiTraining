using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class Session {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A reference to the related School resource. */
    public SchoolReference schoolReference { get; set; }

    /* A reference to the related SchoolYearType resource. */
    public SchoolYearTypeReference schoolYearTypeReference { get; set; }

    /* The term for the session during the school year. */
    public string termType { get; set; }

    /* The identifier for the calendar for the academic session (e.g., 2010/11, 2011 Summer).  NEDM: Session Type   */
    public string name { get; set; }

    /* The statrt date for the academic week.   */
    public DateTime? beginDate { get; set; }

    /* Month, day and year of the last day of the instruction for the school year.  NEDM: Last Day of Class for Students   */
    public DateTime? endDate { get; set; }

    /* The total number of instructional days in the school calendar.  NEDM: Total Days in Session   */
    public int? totalInstructionalDays { get; set; }

    /* An unordered collection of sessionAcademicWeeks.  This entity represents the prescribed span of time when an education institution is open, instruction is provided and students are under the direction and guidance of teachers and/or education institution administration. A session may be interrupted by one or more vacations. */
    public List<SessionAcademicWeek> academicWeeks { get; set; }

    /* An unordered collection of sessionGradingPeriods.  This entity represents the prescribed span of time when an education institution is open, instruction is provided and students are under the direction and guidance of teachers and/or education institution administration. A session may be interrupted by one or more vacations. */
    public List<SessionGradingPeriod> gradingPeriods { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
