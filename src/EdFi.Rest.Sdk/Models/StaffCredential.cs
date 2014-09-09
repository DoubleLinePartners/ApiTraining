using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class StaffCredential {
    /* The field of certification for the certificate (e.g., Mathematics, Music) */
    public string credentialFieldDescriptor { get; set; }

    /* An indication of the category of credential an individual holds.   */
    public string credentialType { get; set; }

    /* A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. */
    public string levelDescriptor { get; set; }

    /* A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. */
    public string teachingCredentialDescriptor { get; set; }

    /* The month, day, and year on which an active credential was issued to an individual.   */
    public DateTime? credentialIssuanceDate { get; set; }

    /* The month, day, and year on which an active credential held by an individual will expire.   */
    public DateTime? credentialExpirationDate { get; set; }

    /* An indication of the pre-determined criteria for granting the teaching credential that an individual holds.   */
    public string teachingCredentialBasisType { get; set; }

    /* Key for StateAbbreviationType */
    public string stateOfIssueStateAbbreviationType { get; set; }

    /*  */
    public string licenseNumber { get; set; }

    }
}
