using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class LanguageDescriptor {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. */
    public int? languageDescriptorId { get; set; }

    /* A globally unique namespace that identifies this descriptor set. Author is strongly encouraged to use the Universal Resource Identifier (http, ftp, file, etc.) for the source of the descriptor definition. Best practice is for this source to be the descriptor file itself, so that it can be machine-readable and be fetched in real-time, if necessary. */
    public string @namespace { get; set; }

    /* A code or abbreviation that is used to refer to the descriptor. */
    public string codeValue { get; set; }

    /* A shortened description for the descriptor. */
    public string shortDescription { get; set; }

    /* The description of the descriptor. */
    public string description { get; set; }

    /* A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. */
    public int? priorDescriptorId { get; set; }

    /* The beginning date of the period when the descriptor is in effect. If omitted, the default is immediate effectiveness. */
    public DateTime? effectiveBeginDate { get; set; }

    /* The end date of the period when the descriptor is in effect. */
    public DateTime? effectiveEndDate { get; set; }

    /* Language(s) the individual uses to communicate */
    public string languageType { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
