using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class LevelOfEducationType {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* Key for LevelOfEducation */
    public int? levelOfEducationTypeId { get; set; }

    /* Code for LevelOfEducation type. */
    public string codeValue { get; set; }

    /* Description for LevelOfEducation type. */
    public string description { get; set; }

    /* Short description for LevelOfEducation type. */
    public string shortDescription { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
