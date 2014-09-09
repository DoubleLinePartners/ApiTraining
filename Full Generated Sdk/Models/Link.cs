using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class Link {
    /* Describes the nature of the relationship to the referenced resource. */
    public string rel { get; set; }

    /* The URL to the related resource. */
    public string href { get; set; }

    }
}
