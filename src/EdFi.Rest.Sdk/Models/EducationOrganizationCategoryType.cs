using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class EducationOrganizationCategoryType {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* Key for EducationOrganizationCategoryType */
    public int? educationOrganizationCategoryTypeId { get; set; }

    /* The classification of the education agency within the geographic boundaries of a state according to the level of administrative and operational control granted by the state. */
    public string shortDescription { get; set; }

    /* The description of the descriptor. */
    public string description { get; set; }

    /*  */
    public string codeValue { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
