using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class ClassPeriodReference {
    /* School Identity Column */
    public int? schoolId { get; set; }

    /* An indication of the portion of a typical daily session in which students receive instruction in a specified subject (e.g., morning, sixth period, block period, or AB schedules).   NEDM: Class Period   */
    public string name { get; set; }

    /* Represents a hyperlink to the related classPeriod resource. */
    public Link link { get; set; }

    }
}
