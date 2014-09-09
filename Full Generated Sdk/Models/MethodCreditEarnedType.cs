using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class MethodCreditEarnedType {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* Key for MethodCreditEarned */
    public int? methodCreditEarnedTypeId { get; set; }

    /* Code for MethodCreditEarned type. */
    public string codeValue { get; set; }

    /* The description of the descriptor. */
    public string description { get; set; }

    /*  */
    public string shortDescription { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
