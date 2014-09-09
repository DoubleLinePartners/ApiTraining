using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class PostSecondaryEventPostSecondaryInstitution {
    /* The postsecondary institution associated with the event. */
    public string nameOfInstitution { get; set; }

    /* The ID of the post secondary institution. */
    public string postSecondaryInstitutionId { get; set; }

    /* A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. */
    public string postSecondaryInstitutionLevelType { get; set; }

    /* Key for AdministrationFundingControl */
    public string administrativeFundingControlDescriptor { get; set; }

    /* An unordered collection of postSecondaryEventPostSecondaryInstitutionIdentificationCodes.  An organization that provides educational programs for individuals who have completed or otherwise left educational programs in secondary school(s). */
    public List<PostSecondaryEventPostSecondaryInstitutionIdentificationCode> identificationCodes { get; set; }

    /* An unordered collection of postSecondaryEventPostSecondaryInstitutionMediumOfInstructions.  An organization that provides educational programs for individuals who have completed or otherwise left educational programs in secondary school(s). */
    public List<PostSecondaryEventPostSecondaryInstitutionMediumOfInstruction> mediumOfInstructions { get; set; }

    }
}
