using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class EducationOrganizationNetwork {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* EducationOrganization Identity Column */
    public int? educationOrganizationNetworkId { get; set; }

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

    /* A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. */
    public string networkPurposeType { get; set; }

    /* An unordered collection of educationOrganizationAddresses.  This entity is a self-organized membership network of peer-level EdOrgs intended to provide shared services or collective procurement. */
    public List<EducationOrganizationAddress> addresses { get; set; }

    /* An unordered collection of educationOrganizationCategories.  This entity is a self-organized membership network of peer-level EdOrgs intended to provide shared services or collective procurement. */
    public List<EducationOrganizationCategory> educationOrganizationCategories { get; set; }

    /* An unordered collection of educationOrganizationIdentificationCodes.  This entity is a self-organized membership network of peer-level EdOrgs intended to provide shared services or collective procurement. */
    public List<EducationOrganizationIdentificationCode> identificationCodes { get; set; }

    /* An unordered collection of educationOrganizationInstitutionTelephones.  This entity is a self-organized membership network of peer-level EdOrgs intended to provide shared services or collective procurement. */
    public List<EducationOrganizationInstitutionTelephone> institutionTelephones { get; set; }

    /* An unordered collection of educationOrganizationInternationalAddresses.  This entity is a self-organized membership network of peer-level EdOrgs intended to provide shared services or collective procurement. */
    public List<EducationOrganizationInternationalAddress> internationalAddresses { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
