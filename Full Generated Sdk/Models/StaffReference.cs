using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class StaffReference {
    /* A unique alpha-numeric code assigned to a staff. */
    public string staffUniqueId { get; set; }

    /* Represents a hyperlink to the related staff resource. */
    public Link link { get; set; }

    }
}
