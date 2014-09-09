using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class InterventionPrescriptionReference {
    /* A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. */
    public string identificationCode { get; set; }

    /*  */
    public int? educationOrganizationId { get; set; }

    /* Represents a hyperlink to the related interventionPrescription resource. */
    public Link link { get; set; }

    }
}
