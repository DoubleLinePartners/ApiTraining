using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class AcademicSubjectType {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* Key for AcademicSubject */
    public int? academicSubjectTypeId { get; set; }

    /* Code for academic subject type. */
    public string codeValue { get; set; }

    /* Description for academic subject type. */
    public string description { get; set; }

    /* A shortened description for the descriptor. */
    public string shortDescription { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
