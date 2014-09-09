using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class GraduationPlanCreditsBySubject {
    /* The intended major subject area of the graduation requirement. */
    public string academicSubjectDescriptor { get; set; }

    /* The value of credits or units of value awarded for the completion of a course. */
    public double? credit { get; set; }

    /* Key for Credit */
    public string creditType { get; set; }

    /* Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. */
    public double? creditConversion { get; set; }

    }
}
