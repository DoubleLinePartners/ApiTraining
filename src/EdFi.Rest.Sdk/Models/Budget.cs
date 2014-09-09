using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class Budget {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A reference to the related Account resource. */
    public AccountReference accountReference { get; set; }

    /* The date of the reported budget element. */
    public DateTime? asOfDate { get; set; }

    /* Amount budgeted for the account for this fiscal year.   */
    public double? amount { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
