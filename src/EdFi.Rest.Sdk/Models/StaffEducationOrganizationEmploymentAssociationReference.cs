using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class StaffEducationOrganizationEmploymentAssociationReference {
    /* A unique alpha-numeric code assigned to a staff. */
    public string staffUniqueId { get; set; }

    /* EducationOrganization Identity Column */
    public int? educationOrganizationId { get; set; }

    /* A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. */
    public string employmentStatusDescriptor { get; set; }

    /* The month, day, and year on which a contract between an individual and a governing authority specifies that employment is to begin (or the date on which the agreement is made valid).  NEDM: Contract Beginning Date */
    public DateTime? hireDate { get; set; }

    /* Represents a hyperlink to the related staffEducationOrganizationEmploymentAssociation resource. */
    public Link link { get; set; }

    }
}
