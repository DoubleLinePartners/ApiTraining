using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class Account {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A reference to the related EducationOrganization resource. */
    public EducationOrganizationReference educationOrganizationReference { get; set; }

    /* The alpha-numeric string that identifies the account. */
    public string number { get; set; }

    /* The financial accounting year.  NEDM: Fiscal Year   */
    public int? fiscalYear { get; set; }

    /* An unordered collection of accountCodes.  This financial entity represents a funding source combined with its purpose and type of transaction. It provides a formal record of the debits and credits relating to the specific account. */
    public List<AccountCode> codes { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
