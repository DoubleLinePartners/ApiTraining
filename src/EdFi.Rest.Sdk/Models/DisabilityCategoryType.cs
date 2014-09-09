using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class DisabilityCategoryType {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. */
    public int? disabilityCategoryTypeId { get; set; }

    /* A shortened description for the descriptor. */
    public string shortDescription { get; set; }

    /*  */
    public string codeValue { get; set; }

    /*  */
    public string description { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
