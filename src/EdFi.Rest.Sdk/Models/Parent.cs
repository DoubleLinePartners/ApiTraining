using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class Parent {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A unique alpha-numeric code assigned to a parent. */
    public string parentUniqueId { get; set; }

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

    /* The login ID for the user; used for security access control interface. */
    public string loginId { get; set; }

    /* An unordered collection of parentAddresses.  This entity represents a parent or guardian of a student, such as mother, father or caretaker. */
    public List<ParentAddress> addresses { get; set; }

    /* An unordered collection of parentElectronicMails.  This entity represents a parent or guardian of a student, such as mother, father or caretaker. */
    public List<ParentElectronicMail> electronicMails { get; set; }

    /* An unordered collection of parentIdentificationDocuments.  This entity represents a parent or guardian of a student, such as mother, father or caretaker. */
    public List<ParentIdentificationDocument> identificationDocuments { get; set; }

    /* An unordered collection of parentInternationalAddresses.  This entity represents a parent or guardian of a student, such as mother, father or caretaker. */
    public List<ParentInternationalAddress> internationalAddresses { get; set; }

    /* An unordered collection of parentLanguages.  This entity represents a parent or guardian of a student, such as mother, father or caretaker. */
    public List<ParentLanguage> languages { get; set; }

    /* An unordered collection of parentOtherNames.  This entity represents a parent or guardian of a student, such as mother, father or caretaker. */
    public List<ParentOtherName> otherNames { get; set; }

    /* An unordered collection of parentTelephones.  This entity represents a parent or guardian of a student, such as mother, father or caretaker. */
    public List<ParentTelephone> telephones { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
