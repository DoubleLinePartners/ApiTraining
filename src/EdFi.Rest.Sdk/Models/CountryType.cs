using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class CountryType {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /*  */
    public int? countryTypeId { get; set; }

    /*  */
    public string codeValue { get; set; }

    /*  */
    public string shortDescription { get; set; }

    /*  */
    public string description { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
