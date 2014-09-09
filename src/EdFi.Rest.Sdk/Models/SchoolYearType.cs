using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class SchoolYearType {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* Key for School */
    public int? schoolYear { get; set; }

    /* Description for SchoolYear type. */
    public string schoolYearDescription { get; set; }

    /* Code for SchoolYear type. */
    public bool? currentSchoolYear { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
