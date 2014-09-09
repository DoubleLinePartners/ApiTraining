using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class ClassPeriod {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A reference to the related School resource. */
    public SchoolReference schoolReference { get; set; }

    /* An indication of the portion of a typical daily session in which students receive instruction in a specified subject (e.g., morning, sixth period, block period, or AB schedules).   NEDM: Class Period   */
    public string name { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
