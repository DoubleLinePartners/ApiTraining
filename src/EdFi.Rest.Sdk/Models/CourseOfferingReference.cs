using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class CourseOfferingReference {
    /* School Identity Column */
    public int? schoolId { get; set; }

    /* The term for the session during the school year. */
    public string termType { get; set; }

    /* The identifier for the school year (e.g., 2010/11).   */
    public int? schoolYear { get; set; }

    /* The local code assigned by the LEA or Campus that identifies the organization of subject matter and related learning experiences provided for the instruction of students.   */
    public string localCourseCode { get; set; }

    /* Represents a hyperlink to the related courseOffering resource. */
    public Link link { get; set; }

    }
}
