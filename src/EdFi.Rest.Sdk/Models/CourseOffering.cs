using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class CourseOffering {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A reference to the related Course resource. */
    public CourseReference courseReference { get; set; }

    /* A reference to the related School resource. */
    public SchoolReference schoolReference { get; set; }

    /* A reference to the related Session resource. */
    public SessionReference sessionReference { get; set; }

    /* The local code assigned by the LEA or Campus that identifies the organization of subject matter and related learning experiences provided for the instruction of students.   */
    public string localCourseCode { get; set; }

    /* The descriptive name given to a course of study offered in the school, if different from the CourseTitle. */
    public string localCourseTitle { get; set; }

    /* The plannned total number of clock minutes of instruction for this course offering. Generally, this should be at least as many minutes as is required for completion by the related state- or district-defined Course. */
    public int? instructionalTimePlanned { get; set; }

    /* An unordered collection of courseOfferingCurriculumUseds.  This entity represents an offering of a course by school during a session, representing the course catalog of available courses. */
    public List<CourseOfferingCurriculumUsed> curriculumUseds { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
