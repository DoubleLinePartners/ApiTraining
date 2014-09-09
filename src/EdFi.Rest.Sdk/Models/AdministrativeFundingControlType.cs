using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class AdministrativeFundingControlType {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* Key for AdministrationFundingControl */
    public int? administrativeFundingControlTypeId { get; set; }

    /* Code for AdministrationFundingControl type. */
    public string codeValue { get; set; }

    /* A shortened description for the descriptor. */
    public string shortDescription { get; set; }

    /* The description of the descriptor. */
    public string description { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
