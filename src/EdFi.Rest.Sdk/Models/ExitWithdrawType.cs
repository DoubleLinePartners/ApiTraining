using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class ExitWithdrawType {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* Key for ExitWithdraw */
    public int? exitWithdrawTypeId { get; set; }

    /* Code for ExitWithdraw type. */
    public string codeValue { get; set; }

    /* Description for ExitWithdraw type. */
    public string description { get; set; }

    /* Short description for exit withdraw type. */
    public string shortDescription { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
