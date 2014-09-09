using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class StateEducationAgency {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* StateEducationAgency Identity Column */
    public int? stateEducationAgencyId { get; set; }

    /* The identifier assigned to an education agency by the State Education Agency (SEA).  Also known as the State LEP ID.  NEDM: IdentificationCode, LEA Identifier (State)   */
    public string stateOrganizationId { get; set; }

    /* The full, legally accepted name of the institution.  NEDM: Name of Institution   */
    public string nameOfInstitution { get; set; }

    /* A short name for the institution.   */
    public string shortNameOfInstitution { get; set; }

    /* The public web site address (URL) for the educational organization.   */
    public string webSite { get; set; }

    /* The current operational status of the education organization (e.g., active, inactive). */
    public string operationalStatusType { get; set; }

    /* An unordered collection of educationOrganizationAddresses.  This entity represents the agency of the state charged with the primary responsibility for coordinating and supervising public instruction, including the setting of standards for elementary and secondary instructional programs. */
    public List<EducationOrganizationAddress> addresses { get; set; }

    /* An unordered collection of educationOrganizationCategories.  This entity represents the agency of the state charged with the primary responsibility for coordinating and supervising public instruction, including the setting of standards for elementary and secondary instructional programs. */
    public List<EducationOrganizationCategory> educationOrganizationCategories { get; set; }

    /* An unordered collection of educationOrganizationIdentificationCodes.  This entity represents the agency of the state charged with the primary responsibility for coordinating and supervising public instruction, including the setting of standards for elementary and secondary instructional programs. */
    public List<EducationOrganizationIdentificationCode> identificationCodes { get; set; }

    /* An unordered collection of educationOrganizationInstitutionTelephones.  This entity represents the agency of the state charged with the primary responsibility for coordinating and supervising public instruction, including the setting of standards for elementary and secondary instructional programs. */
    public List<EducationOrganizationInstitutionTelephone> institutionTelephones { get; set; }

    /* An unordered collection of educationOrganizationInternationalAddresses.  This entity represents the agency of the state charged with the primary responsibility for coordinating and supervising public instruction, including the setting of standards for elementary and secondary instructional programs. */
    public List<EducationOrganizationInternationalAddress> internationalAddresses { get; set; }

    /* An unordered collection of stateEducationAgencyAccountabilities.  This entity represents the agency of the state charged with the primary responsibility for coordinating and supervising public instruction, including the setting of standards for elementary and secondary instructional programs. */
    public List<StateEducationAgencyAccountability> accountabilities { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
