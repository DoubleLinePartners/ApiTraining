using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class LanguageType {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* Language(s) the individual uses to communicate */
    public int? languageTypeId { get; set; }

    /* Code for Languages type. */
    public string codeValue { get; set; }

    /* Description for Languages type. */
    public string description { get; set; }

    /* Short description for languages type. */
    public string shortDescription { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
