using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class EmploymentStatusType {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* Key for EmploymentStatus */
    public int? employmentStatusTypeId { get; set; }

    /* Code for EmploymentStatus type. */
    public string codeValue { get; set; }

    /* Description for EmploymentStatus type. */
    public string description { get; set; }

    /* Short description for employment status type. */
    public string shortDescription { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
