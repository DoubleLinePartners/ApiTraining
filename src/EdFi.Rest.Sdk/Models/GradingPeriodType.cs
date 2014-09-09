using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class GradingPeriodType {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* Key for GradingPeriod */
    public int? gradingPeriodTypeId { get; set; }

    /* Code for GradingPeriod type. */
    public string codeValue { get; set; }

    /* The description of the descriptor. */
    public string description { get; set; }

    /* The sequential order of this period relative to other periods. */
    public int? periodSequence { get; set; }

    /*  */
    public string shortDescription { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
