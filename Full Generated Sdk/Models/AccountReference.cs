using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class AccountReference {
    /* EducationOrganization Identity Column */
    public int? educationOrganizationId { get; set; }

    /* The alpha-numeric string that identifies the account. */
    public string number { get; set; }

    /* The financial accounting year.  NEDM: Fiscal Year   */
    public int? fiscalYear { get; set; }

    /* Represents a hyperlink to the related account resource. */
    public Link link { get; set; }

    }
}
