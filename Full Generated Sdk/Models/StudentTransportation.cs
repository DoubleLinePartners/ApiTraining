using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class StudentTransportation {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A reference to the related School resource. */
    public SchoolReference schoolReference { get; set; }

    /* A reference to the related Student resource. */
    public StudentReference studentReference { get; set; }

    /*  */
    public string amBusNumber { get; set; }

    /*  */
    public string pmBusNumber { get; set; }

    /*  */
    public double? estimatedMilesFromSchool { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
