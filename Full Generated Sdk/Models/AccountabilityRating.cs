using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class AccountabilityRating {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A reference to the related EducationOrganization resource. */
    public EducationOrganizationReference educationOrganizationReference { get; set; }

    /* A reference to the related SchoolYearType resource. */
    public SchoolYearTypeReference schoolYearTypeReference { get; set; }

    /* The title of the rating (e.g., Campus Rating, Safety Score, etc.)   */
    public string ratingTitle { get; set; }

    /* An accountability rating level, designation, or assessment.   */
    public string rating { get; set; }

    /* The date the rating was awarded.   */
    public DateTime? ratingDate { get; set; }

    /* The organization assigning the accountability rating.   */
    public string ratingOrganization { get; set; }

    /* The rating program (e.g., NCLB, AEIS, etc.)   */
    public string ratingProgram { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
