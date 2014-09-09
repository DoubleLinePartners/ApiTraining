using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class School {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A reference to the related LocalEducationAgency resource. */
    public LocalEducationAgencyReference localEducationAgencyReference { get; set; }

    /* School Identity Column */
    public int? schoolId { get; set; }

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

    /* The instructional categorization of the school (e.g., Regular, Alternative, etc.)     */
    public string type { get; set; }

    /* A school or agency providing free public elementary or secondary education to eligible students under a specific charter granted by the state legislature or other appropriate authority and designated by such authority to be a charter school.     */
    public string charterStatusType { get; set; }

    /* Denotes the Title I Part A designation for the school.   */
    public string titleIPartASchoolDesignationType { get; set; }

    /* A school that has been designed: 1) to attract students of different racial/ethnic backgrounds for the purpose of reducing, preventing, or eliminating racial isolation; and/or 2)to provide an academic or social focus on a particular theme (e.g., science/math, performing arts, gifted/talented, or foreign language).   */
    public string magnetSpecialProgramEmphasisSchoolType { get; set; }

    /* A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. */
    public string administrativeFundingControlDescriptor { get; set; }

    /* A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. */
    public string internetAccessType { get; set; }

    /* An unordered collection of educationOrganizationAddresses.  This entity represents an educational organization that includes staff and students who participate in classes and educational activity groups. */
    public List<EducationOrganizationAddress> addresses { get; set; }

    /* An unordered collection of educationOrganizationCategories.  This entity represents an educational organization that includes staff and students who participate in classes and educational activity groups. */
    public List<EducationOrganizationCategory> educationOrganizationCategories { get; set; }

    /* An unordered collection of educationOrganizationIdentificationCodes.  This entity represents an educational organization that includes staff and students who participate in classes and educational activity groups. */
    public List<EducationOrganizationIdentificationCode> identificationCodes { get; set; }

    /* An unordered collection of educationOrganizationInstitutionTelephones.  This entity represents an educational organization that includes staff and students who participate in classes and educational activity groups. */
    public List<EducationOrganizationInstitutionTelephone> institutionTelephones { get; set; }

    /* An unordered collection of educationOrganizationInternationalAddresses.  This entity represents an educational organization that includes staff and students who participate in classes and educational activity groups. */
    public List<EducationOrganizationInternationalAddress> internationalAddresses { get; set; }

    /* An unordered collection of schoolCategories.  This entity represents an educational organization that includes staff and students who participate in classes and educational activity groups. */
    public List<SchoolCategory> schoolCategories { get; set; }

    /* An unordered collection of schoolGradeLevels.  This entity represents an educational organization that includes staff and students who participate in classes and educational activity groups. */
    public List<SchoolGradeLevel> gradeLevels { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
