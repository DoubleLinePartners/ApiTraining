using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class CourseReference {
    /* The Education Organization that defines the curriculum and courses offered - often the LEA or school. */
    public int? educationOrganizationId { get; set; }

    /* TThe actual code that identifies the organization of subject matter and related learning experiences provided for the instruction of students.   */
    public string code { get; set; }

    /* Represents a hyperlink to the related course resource. */
    public Link link { get; set; }

    }
}
