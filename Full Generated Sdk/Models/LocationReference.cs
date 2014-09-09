using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class LocationReference {
    /* Location Identity Column */
    public int? schoolId { get; set; }

    /* A unique number or alphanumeric code assigned to a room by a school, school system, state, or other agency or entity.   */
    public string classroomIdentificationCode { get; set; }

    /* Represents a hyperlink to the related location resource. */
    public Link link { get; set; }

    }
}
