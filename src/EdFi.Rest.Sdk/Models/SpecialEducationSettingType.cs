using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class SpecialEducationSettingType {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. */
    public int? specialEducationSettingTypeId { get; set; }

    /* A code or abbreviation that is used to refer to the descriptor. */
    public string codeValue { get; set; }

    /* The description of the descriptor. */
    public string description { get; set; }

    /* A shortened description for the descriptor. */
    public string shortDescription { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
