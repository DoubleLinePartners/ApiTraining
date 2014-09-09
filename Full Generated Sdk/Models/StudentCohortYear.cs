using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class StudentCohortYear {
    /* A reference to the related SchoolYearType resource. */
    public SchoolYearTypeReference schoolYearTypeReference { get; set; }

    /* Key for CohortYear */
    public string cohortYearType { get; set; }

    }
}
