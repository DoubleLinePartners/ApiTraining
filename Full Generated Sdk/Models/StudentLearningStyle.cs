using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class StudentLearningStyle {
    /* The student's relative preference expressed as a percent to visual learning. */
    public double? visualLearning { get; set; }

    /* The student's relative preference expressed as a percent to auditory learning. */
    public double? auditoryLearning { get; set; }

    /* The student's relative preference expressed as a percent to kinesthetic or tactile learning. */
    public double? tactileLearning { get; set; }

    }
}
