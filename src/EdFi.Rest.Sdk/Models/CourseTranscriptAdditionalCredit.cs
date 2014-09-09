using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class CourseTranscriptAdditionalCredit {
    /* The type of credits awarded or earned for the course. */
    public string additionalCreditType { get; set; }

    /* The number of credits awarded or earned for the course. */
    public double? credit { get; set; }

    }
}
