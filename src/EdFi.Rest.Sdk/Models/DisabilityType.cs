using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class DisabilityType {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* Key for Disability */
    public int? disabilityTypeId { get; set; }

    /* Code for Disability type. */
    public string codeValue { get; set; }

    /* Description for Disability type. */
    public string description { get; set; }

    /* Short description for the disability type. */
    public string shortDescription { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
