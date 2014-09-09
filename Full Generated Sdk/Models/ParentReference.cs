using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class ParentReference {
    /* A unique alpha-numeric code assigned to a parent. */
    public string parentUniqueId { get; set; }

    /* Represents a hyperlink to the related parent resource. */
    public Link link { get; set; }

    }
}
