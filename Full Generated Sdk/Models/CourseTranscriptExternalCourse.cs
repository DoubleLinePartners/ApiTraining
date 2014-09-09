using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class CourseTranscriptExternalCourse {
    /* The name of the institution that provided the instruction */
    public string nameOfInstitution { get; set; }

    /* The course code from the institution that provided the instruction. */
    public string externalCourseCode { get; set; }

    /* The course title from the institution that provided the instruction. */
    public string externalCourseTitle { get; set; }

    }
}
