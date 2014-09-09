using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class FeederSchoolAssociation {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A reference to the related School resource. */
    public SchoolReference feederSchoolReference { get; set; }

    /* A reference to the related School resource. */
    public SchoolReference schoolReference { get; set; }

    /* The month, day, and year of the first dat of the feeder school association. */
    public DateTime? beginDate { get; set; }

    /* The month, day, and year of the last day of the feeder school association. */
    public DateTime? endDate { get; set; }

    /* The description of the descriptor. */
    public string feederRelationshipDescription { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
