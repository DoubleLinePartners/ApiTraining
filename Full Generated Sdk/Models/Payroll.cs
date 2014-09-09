using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class Payroll {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A reference to the related Account resource. */
    public AccountReference accountReference { get; set; }

    /* A reference to the related Staff resource. */
    public StaffReference staffReference { get; set; }

    /* The date of the reported payroll element. */
    public DateTime? asOfDate { get; set; }

    /* Current balance (amount paid to employee) for account for the fiscal year.   */
    public double? amountToDate { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
