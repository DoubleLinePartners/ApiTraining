using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class CourseIdentificationCode {
    /* A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. */
    public string courseCodeSystemType { get; set; }

    /* The organization code or name assigning the Course Identification Code. */
    public string assigningOrganizationIdentificationCode { get; set; }

    /* A unique number or alphanumeric code assigned to a course by a school, school system, a state, or other agency or entity.  For multi-part course codes, concatenate the parts separated by a ""/"".  For example, consider the following SCED code:     subject = 20 Math     course = 272 Geometry     level = G General     credits = 1.00    course sequence 1 of 1  would be entered as 20/272/G/1.00/1 of 1 */
    public string identificationCode { get; set; }

    }
}
