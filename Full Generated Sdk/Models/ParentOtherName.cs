using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class ParentOtherName {
    /* Key for OtherName */
    public string otherNameType { get; set; }

    /* A prefix used to denote the title, degree, position or seniority of the person. */
    public string personalTitlePrefix { get; set; }

    /* A name given to an individual at birth, baptism, or during another naming ceremony, or through legal change.  NEDM: First Name   */
    public string firstName { get; set; }

    /* A secondary name given to an individual at birth, baptism, or during another naming ceremony.  NEDM: Middle Name   */
    public string middleName { get; set; }

    /* The name borne in common by members of a family.  NEDM: Last Name/Surname   */
    public string lastSurname { get; set; }

    /* An appendage, if any, used to denote an individual's generation in his family (e.g., Jr., Sr., III). */
    public string generationCodeSuffix { get; set; }

    }
}
