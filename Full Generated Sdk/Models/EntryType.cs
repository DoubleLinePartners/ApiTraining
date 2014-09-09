using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class EntryType {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* Key for Entry */
    public int? entryTypeId { get; set; }

    /* Code for Entry type. */
    public string codeValue { get; set; }

    /* Description for Entry type. */
    public string description { get; set; }

    /* Short description for entry type. */
    public string shortDescription { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
