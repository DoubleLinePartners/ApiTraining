using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class LocalEducationAgencyAccountability {
    /* A reference to the related SchoolYearType resource. */
    public SchoolYearTypeReference schoolYearTypeReference { get; set; }

    /* A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. */
    public string gunFreeSchoolsActReportingStatusType { get; set; }

    /* A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. */
    public string schoolChoiceImplementStatusType { get; set; }

    }
}
