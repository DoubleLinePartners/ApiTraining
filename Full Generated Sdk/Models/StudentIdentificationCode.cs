using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class StudentIdentificationCode {
    /* Key for StudentIdentificationSystem */
    public string studentIdentificationSystemType { get; set; }

    /* The organization code or name assigning the assessment identification code. */
    public string assigningOrganizationIdentificationCode { get; set; }

    /* A unique number or alphanumeric code assigned to a student by a school, school system, a state, or other agency or entity. */
    public string identificationCode { get; set; }

    }
}
