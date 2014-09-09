using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class LocalEducationAgency {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A reference to the related EducationServiceCenter resource. */
    public EducationServiceCenterReference educationServiceCenterReference { get; set; }

    /* A reference to the related StateEducationAgency resource. */
    public StateEducationAgencyReference stateEducationAgencyReference { get; set; }

    /* EducationOrganization Identity Column */
    public int? localEducationAgencyId { get; set; }

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
    public int? parentLocalEducationAgencyId { get; set; }

    /* Key for LEACategory */
    public string categoryType { get; set; }

    /* Key for CharterStatus */
    public string charterStatusType { get; set; }

    /* An unordered collection of educationOrganizationAddresses.  This entity represents an administrative unit at the local level, which exists primarily to operate schools or to contract for educational services.  It includes school districts, charter schools, charter management organizations or other local administrative organizations. */
    public List<EducationOrganizationAddress> addresses { get; set; }

    /* An unordered collection of educationOrganizationCategories.  This entity represents an administrative unit at the local level, which exists primarily to operate schools or to contract for educational services.  It includes school districts, charter schools, charter management organizations or other local administrative organizations. */
    public List<EducationOrganizationCategory> educationOrganizationCategories { get; set; }

    /* An unordered collection of educationOrganizationIdentificationCodes.  This entity represents an administrative unit at the local level, which exists primarily to operate schools or to contract for educational services.  It includes school districts, charter schools, charter management organizations or other local administrative organizations. */
    public List<EducationOrganizationIdentificationCode> identificationCodes { get; set; }

    /* An unordered collection of educationOrganizationInstitutionTelephones.  This entity represents an administrative unit at the local level, which exists primarily to operate schools or to contract for educational services.  It includes school districts, charter schools, charter management organizations or other local administrative organizations. */
    public List<EducationOrganizationInstitutionTelephone> institutionTelephones { get; set; }

    /* An unordered collection of educationOrganizationInternationalAddresses.  This entity represents an administrative unit at the local level, which exists primarily to operate schools or to contract for educational services.  It includes school districts, charter schools, charter management organizations or other local administrative organizations. */
    public List<EducationOrganizationInternationalAddress> internationalAddresses { get; set; }

    /* An unordered collection of localEducationAgencyAccountabilities.  This entity represents an administrative unit at the local level, which exists primarily to operate schools or to contract for educational services.  It includes school districts, charter schools, charter management organizations or other local administrative organizations. */
    public List<LocalEducationAgencyAccountability> accountabilities { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
