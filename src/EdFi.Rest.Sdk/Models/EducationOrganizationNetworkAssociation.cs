using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class EducationOrganizationNetworkAssociation {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A reference to the related EducationOrganization resource. */
    public EducationOrganizationReference memberEducationOrganizationReference { get; set; }

    /* A reference to the related EducationOrganizationNetwork resource. */
    public EducationOrganizationNetworkReference educationOrganizationNetworkReference { get; set; }

    /* The date on which the EdOrg joined this network. */
    public DateTime? beginDate { get; set; }

    /* The date on which the EdOrg left this network. */
    public DateTime? endDate { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
