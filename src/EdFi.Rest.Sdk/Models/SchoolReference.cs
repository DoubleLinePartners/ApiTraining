using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class SchoolReference {
    /* School Identity Column */
    public int? schoolId { get; set; }

    /* Represents a hyperlink to the related school resource. */
    public Link link { get; set; }

    }
}
