using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class GraduationPlanType {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* Key for graduation plan type. */
    public int? graduationPlanTypeId { get; set; }

    /* Code for GraduationPlan type. */
    public string codeValue { get; set; }

    /* A shortened description for the descriptor. */
    public string shortDescription { get; set; }

    /* The description of the descriptor. */
    public string description { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
