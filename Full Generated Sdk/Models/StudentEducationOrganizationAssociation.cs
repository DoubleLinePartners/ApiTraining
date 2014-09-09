using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class StudentEducationOrganizationAssociation {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A reference to the related EducationOrganization resource. */
    public EducationOrganizationReference educationOrganizationReference { get; set; }

    /* A reference to the related Student resource. */
    public StudentReference studentReference { get; set; }

    /* A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. */
    public string responsibilityDescriptor { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
