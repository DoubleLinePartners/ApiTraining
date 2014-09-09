using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class EducationOrganizationInterventionPrescriptionAssociation {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A reference to the related EducationOrganization resource. */
    public EducationOrganizationReference educationOrganizationReference { get; set; }

    /* A reference to the related InterventionPrescription resource. */
    public InterventionPrescriptionReference interventionPrescriptionReference { get; set; }

    /* The begin date of the period during which the InterventionPrescription is available. */
    public DateTime? beginDate { get; set; }

    /* The end date of the period during which the InterventionPrescription is available. */
    public DateTime? endDate { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
