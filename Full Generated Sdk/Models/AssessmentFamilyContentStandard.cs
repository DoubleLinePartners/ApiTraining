using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class AssessmentFamilyContentStandard {
    /* A reference to the related EducationOrganization resource. */
    public EducationOrganizationReference mandatingEducationOrganizationReference { get; set; }

    /* The name of the content standard, for example Common Core. */
    public string title { get; set; }

    /* The version identifier for the content. */
    public string version { get; set; }

    /* An unambiguous reference to the standards using a network-resolvable URI. */
    public string uri { get; set; }

    /* The date on which this content was first published. */
    public DateTime? publicationDate { get; set; }

    /* The year at which this content was first published. */
    public int? publicationYear { get; set; }

    /* A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. */
    public string publicationStatusType { get; set; }

    /* The beginning of the period during which this learning standard document is intended for use. */
    public DateTime? beginDate { get; set; }

    /* The end of the period during which this learning standard document is intended for use. */
    public DateTime? endDate { get; set; }

    /* An unordered collection of assessmentFamilyContentStandardAuthors.  An indication as to whether an assessment conforms to a standard (e.g., local standard, statewide standard, regional standard, association standard, etc.). */
    public List<AssessmentFamilyContentStandardAuthor> authors { get; set; }

    }
}
