using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class StudentAssessmentPerformanceLevel {
    /* The ID of the Performance Level Descriptor */
    public string performanceLevelDescriptor { get; set; }

    /* Indicator of whether the student met the designated performance level. */
    public bool? performanceLevelMet { get; set; }

    }
}
