using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class Student {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A unique alpha-numeric code assigned to a student. */
    public string studentUniqueId { get; set; }

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

    /* The set of elements that capture relevant data regarding a person's birth, including birth date and place of birth. */
    public string cityOfBirth { get; set; }

    /* The abbreviation for the name of the state (within the United States) or extra-state jurisdiction in which an individual was born. */
    public string birthStateAbbreviationType { get; set; }

    /* The name of the country in which an individual was born. (Note: A list of countries and codes is currently maintained and updated by the ISO as ISO 3166 on its website: http://www.iso.org/iso/country_codes.htm)  NEDM: Country Of Birth Code */
    public string birthCountryCodeType { get; set; }

    /* For students born outside of the US, the date the student entered the US. */
    public DateTime? dateEnteredUS { get; set; }

    /* Indicator of whether the student was born with other siblings (i.e., twins, triplets, etc.) */
    public bool? multipleBirthStatus { get; set; }

    /* File name for the ProfileThumbnail photograph */
    public string profileThumbnail { get; set; }

    /* An indication that the individual traces his or her origin or descent to Mexico, Puerto Rico, Cuba, Central and South America, and other Spanish cultures, regardless of race. The term, ""Spanish origin,"" can be used in addition to ""Hispanic or Latino."" */
    public bool? hispanicLatinoEthnicity { get; set; }

    /* Previous definition of Ethnicity combining Hispanic/latino and race:  1 - American Indian or Alaskan Native  2 - Asian or Pacific Islander  3 - Black, not of Hispanic origin  4 - Hispanic  5 - White, not of Hispanic origin */
    public string oldEthnicityType { get; set; }

    /* An indication of inadequate financial condition of an individual''s family, as determined by family income, number of family members/dependents, participation in public assistance programs, and/or other characteristics considered relevant by federal, state, and local policy.  NEDM: Economic Disadvantaged Status */
    public bool? economicDisadvantaged { get; set; }

    /* A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. */
    public string schoolFoodServicesEligibilityDescriptor { get; set; }

    /* An indication that the student has sufficient difficulty speaking, reading, writing, or understanding the English language, as to require special English Language services. */
    public string limitedEnglishProficiencyDescriptor { get; set; }

    /* Indicates a state health or weather related event that displaces a group of students, and may require additional funding, educational, or social services. */
    public string displacementStatus { get; set; }

    /* The login ID for the user; used for security access control interface. */
    public string loginId { get; set; }

    /* For students born outside of the US, the Province or jurisdiction in which an individual is born. */
    public string internationalProvinceOfBirth { get; set; }

    /* A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. */
    public string citizenshipStatusType { get; set; }

    /*  */
    public DateTime? firstSchoolEnrollmentDate { get; set; }

    /*  */
    public int? birthCountyFIPSCode { get; set; }

    /*  */
    public string homelessResidenceDescriptor { get; set; }

    /*  */
    public int? eisEnrollmentYear { get; set; }

    /* This entity represents an individual for whom instruction, services and/or care are provided in an early childhood, elementary or secondary educational program under the jurisdiction of a school, education agency or other institution or program. A student is a person who has been enrolled in a school or other educational institution. */
    public StudentLearningStyle learningStyle { get; set; }

    /* An unordered collection of studentAddresses.  This entity represents an individual for whom instruction, services and/or care are provided in an early childhood, elementary or secondary educational program under the jurisdiction of a school, education agency or other institution or program. A student is a person who has been enrolled in a school or other educational institution. */
    public List<StudentAddress> addresses { get; set; }

    /* An unordered collection of studentCharacteristics.  This entity represents an individual for whom instruction, services and/or care are provided in an early childhood, elementary or secondary educational program under the jurisdiction of a school, education agency or other institution or program. A student is a person who has been enrolled in a school or other educational institution. */
    public List<StudentCharacteristic> characteristics { get; set; }

    /* An unordered collection of studentCohortYears.  This entity represents an individual for whom instruction, services and/or care are provided in an early childhood, elementary or secondary educational program under the jurisdiction of a school, education agency or other institution or program. A student is a person who has been enrolled in a school or other educational institution. */
    public List<StudentCohortYear> cohortYears { get; set; }

    /* An unordered collection of studentDisabilities.  This entity represents an individual for whom instruction, services and/or care are provided in an early childhood, elementary or secondary educational program under the jurisdiction of a school, education agency or other institution or program. A student is a person who has been enrolled in a school or other educational institution. */
    public List<StudentDisability> disabilities { get; set; }

    /* An unordered collection of studentElectronicMails.  This entity represents an individual for whom instruction, services and/or care are provided in an early childhood, elementary or secondary educational program under the jurisdiction of a school, education agency or other institution or program. A student is a person who has been enrolled in a school or other educational institution. */
    public List<StudentElectronicMail> electronicMails { get; set; }

    /* An unordered collection of studentIdentificationCodes.  This entity represents an individual for whom instruction, services and/or care are provided in an early childhood, elementary or secondary educational program under the jurisdiction of a school, education agency or other institution or program. A student is a person who has been enrolled in a school or other educational institution. */
    public List<StudentIdentificationCode> identificationCodes { get; set; }

    /* An unordered collection of studentIdentificationDocuments.  This entity represents an individual for whom instruction, services and/or care are provided in an early childhood, elementary or secondary educational program under the jurisdiction of a school, education agency or other institution or program. A student is a person who has been enrolled in a school or other educational institution. */
    public List<StudentIdentificationDocument> identificationDocuments { get; set; }

    /* An unordered collection of studentIndicators.  This entity represents an individual for whom instruction, services and/or care are provided in an early childhood, elementary or secondary educational program under the jurisdiction of a school, education agency or other institution or program. A student is a person who has been enrolled in a school or other educational institution. */
    public List<StudentIndicator> indicators { get; set; }

    /* An unordered collection of studentInternationalAddresses.  This entity represents an individual for whom instruction, services and/or care are provided in an early childhood, elementary or secondary educational program under the jurisdiction of a school, education agency or other institution or program. A student is a person who has been enrolled in a school or other educational institution. */
    public List<StudentInternationalAddress> internationalAddresses { get; set; }

    /* An unordered collection of studentLanguages.  This entity represents an individual for whom instruction, services and/or care are provided in an early childhood, elementary or secondary educational program under the jurisdiction of a school, education agency or other institution or program. A student is a person who has been enrolled in a school or other educational institution. */
    public List<StudentLanguage> languages { get; set; }

    /* An unordered collection of studentOtherNames.  This entity represents an individual for whom instruction, services and/or care are provided in an early childhood, elementary or secondary educational program under the jurisdiction of a school, education agency or other institution or program. A student is a person who has been enrolled in a school or other educational institution. */
    public List<StudentOtherName> otherNames { get; set; }

    /* An unordered collection of studentProgramParticipations.  This entity represents an individual for whom instruction, services and/or care are provided in an early childhood, elementary or secondary educational program under the jurisdiction of a school, education agency or other institution or program. A student is a person who has been enrolled in a school or other educational institution. */
    public List<StudentProgramParticipation> programParticipations { get; set; }

    /* An unordered collection of studentRaces.  This entity represents an individual for whom instruction, services and/or care are provided in an early childhood, elementary or secondary educational program under the jurisdiction of a school, education agency or other institution or program. A student is a person who has been enrolled in a school or other educational institution. */
    public List<StudentRace> races { get; set; }

    /* An unordered collection of studentTelephones.  This entity represents an individual for whom instruction, services and/or care are provided in an early childhood, elementary or secondary educational program under the jurisdiction of a school, education agency or other institution or program. A student is a person who has been enrolled in a school or other educational institution. */
    public List<StudentTelephone> telephones { get; set; }

    /* An unordered collection of studentVisas.  This entity represents an individual for whom instruction, services and/or care are provided in an early childhood, elementary or secondary educational program under the jurisdiction of a school, education agency or other institution or program. A student is a person who has been enrolled in a school or other educational institution. */
    public List<StudentVisa> visas { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
