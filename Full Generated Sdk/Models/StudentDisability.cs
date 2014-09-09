using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class StudentDisability {
    /* A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. */
    public string disabilityDescriptor { get; set; }

    /* A description of the exact disability diagnosis.   */
    public string disabilityDiagnosis { get; set; }

    /* Primary, Secondary, Tertiary, etc.   */
    public int? orderOfDisability { get; set; }

    /*  */
    public DateTime? beginDate { get; set; }

    /*  */
    public DateTime? endDate { get; set; }

    }
}
