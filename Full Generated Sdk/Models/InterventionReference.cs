using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class InterventionReference {
    /* A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. */
    public string identificationCode { get; set; }

    /* EducationOrganization Identity Column */
    public int? educationOrganizationId { get; set; }

    /* Represents a hyperlink to the related intervention resource. */
    public Link link { get; set; }

    }
}
