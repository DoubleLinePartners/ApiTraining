using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class GradeLevelType {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* Key for GradeLevel */
    public int? gradeLevelTypeId { get; set; }

    /* Code for GradeLevel type. */
    public string codeValue { get; set; }

    /* Short description for grade level type. */
    public string shortDescription { get; set; }

    /* Description for GradeLevel type. */
    public string description { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
