using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class StateEducationAgencyAccountability {
    /* A reference to the related SchoolYearType resource. */
    public SchoolYearTypeReference schoolYearTypeReference { get; set; }

    /* An indication of how CTE concentrators are included in the state's computation of its graduation rate. */
    public bool? cteGraduationRateInclusion { get; set; }

    }
}
