using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class SchoolYearTypeReference {
    /* Key for School */
    public int? schoolYear { get; set; }

    /* Represents a hyperlink to the related schoolYearType resource. */
    public Link link { get; set; }

    }
}
