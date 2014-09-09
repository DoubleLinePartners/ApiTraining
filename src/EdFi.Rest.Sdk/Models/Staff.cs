using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class Staff {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A unique alpha-numeric code assigned to a staff. */
    public string staffUniqueId { get; set; }

    /* A prefix used to denote the title, degree, position or seniority of the person. */
    public string personalTitlePrefix { get; set; }

    /* A name given to an individual at birth, baptism, or during another naming ceremony, or through legal change.  NEDM: First Name */
    public string firstName { get; set; }

    /* A secondary name given to an individual at birth, baptism, or during another naming ceremony.  NEDM: Middle Name */
    public string middleName { get; set; }

    /* The name borne in common by members of a family.  NEDM: Last Name/Surname */
    public string lastSurname { get; set; }

    /* An appendage, if any, used to denote an individual's generation in his family (e.g., Jr., Sr., III). */
    public string generationCodeSuffix { get; set; }

    /* The person''s maiden name, if applicable. */
    public string maidenName { get; set; }

    /* A person''s gender. */
    public string sexType { get; set; }

    /* The month, day, and year on which an individual was born. */
    public DateTime? birthDate { get; set; }

    /* An indication that the individual traces his or her origin or descent to Mexico, Puerto Rico, Cuba, Central and South America, and other Spanish cultures, regardless of race. The term, ""Spanish origin,"" can be used in addition to ""Hispanic or Latino."" */
    public bool? hispanicLatinoEthnicity { get; set; }

    /* Previous definition of Ethnicity combining Hispanic/latino and race:  1 - American Indian or Alaskan Native  2 - Asian or Pacific Islander  3 - Black, not of Hispanic origin  4 - Hispanic  5 - White, not of Hispanic origin */
    public string oldEthnicityType { get; set; }

    /* A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. */
    public string highestCompletedLevelOfEducationDescriptor { get; set; }

    /* The total number of years that an individual has previously held a similar professional position in one or more education institutions.  NEDM: Years of Prior Teaching Experience */
    public int? yearsOfPriorProfessionalExperience { get; set; }

    /* The total number of years that an individual has previously held a teaching position in one or more education institutions. */
    public int? yearsOfPriorTeachingExperience { get; set; }

    /* An indication of whether a teacher is classified as highly qualified for his/her assignment according to state definition.  This attribute indicates the teacher is highly qualified for ALL sections being taught.  Section 9101(23) of the ESEA defines the term &ldquo;highly qualified.&rdquo;  NEDM: HQT Qualification Status */
    public bool? highlyQualifiedTeacher { get; set; }

    /* The login ID for the user; used for security access control interface. */
    public string loginId { get; set; }

    /* A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. */
    public string citizenshipStatusType { get; set; }

    /*  */
    public string licensureCheckDescriptor { get; set; }

    /* An unordered collection of staffAddresses.  This entity represents an individual who performs specified activities for any public or private education institution or agency that provides instructional and/or support services to students or staff at the early childhood level through high school completion. For example, this includes: */
    public List<StaffAddress> addresses { get; set; }

    /* An unordered collection of staffCredentials.  This entity represents an individual who performs specified activities for any public or private education institution or agency that provides instructional and/or support services to students or staff at the early childhood level through high school completion. For example, this includes: */
    public List<StaffCredential> credentials { get; set; }

    /* An unordered collection of staffElectronicMails.  This entity represents an individual who performs specified activities for any public or private education institution or agency that provides instructional and/or support services to students or staff at the early childhood level through high school completion. For example, this includes: */
    public List<StaffElectronicMail> electronicMails { get; set; }

    /* An unordered collection of staffIdentificationCodes.  This entity represents an individual who performs specified activities for any public or private education institution or agency that provides instructional and/or support services to students or staff at the early childhood level through high school completion. For example, this includes: */
    public List<StaffIdentificationCode> identificationCodes { get; set; }

    /* An unordered collection of staffIdentificationDocuments.  This entity represents an individual who performs specified activities for any public or private education institution or agency that provides instructional and/or support services to students or staff at the early childhood level through high school completion. For example, this includes: */
    public List<StaffIdentificationDocument> identificationDocuments { get; set; }

    /* An unordered collection of staffInternationalAddresses.  This entity represents an individual who performs specified activities for any public or private education institution or agency that provides instructional and/or support services to students or staff at the early childhood level through high school completion. For example, this includes: */
    public List<StaffInternationalAddress> internationalAddresses { get; set; }

    /* An unordered collection of staffLanguages.  This entity represents an individual who performs specified activities for any public or private education institution or agency that provides instructional and/or support services to students or staff at the early childhood level through high school completion. For example, this includes: */
    public List<StaffLanguage> languages { get; set; }

    /* An unordered collection of staffOtherNames.  This entity represents an individual who performs specified activities for any public or private education institution or agency that provides instructional and/or support services to students or staff at the early childhood level through high school completion. For example, this includes: */
    public List<StaffOtherName> otherNames { get; set; }

    /* An unordered collection of staffRaces.  This entity represents an individual who performs specified activities for any public or private education institution or agency that provides instructional and/or support services to students or staff at the early childhood level through high school completion. For example, this includes: */
    public List<StaffRace> races { get; set; }

    /* An unordered collection of staffTelephones.  This entity represents an individual who performs specified activities for any public or private education institution or agency that provides instructional and/or support services to students or staff at the early childhood level through high school completion. For example, this includes: */
    public List<StaffTelephone> telephones { get; set; }

    /* An unordered collection of staffVisas.  This entity represents an individual who performs specified activities for any public or private education institution or agency that provides instructional and/or support services to students or staff at the early childhood level through high school completion. For example, this includes: */
    public List<StaffVisa> visas { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
