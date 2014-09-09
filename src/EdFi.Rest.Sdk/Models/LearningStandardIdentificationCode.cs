using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class LearningStandardIdentificationCode {
    /* Provide user information to lookup and link to an existing learning standard record in the receiving system */
    public string identificationCode { get; set; }

    /* A unique number or alphanumeric code assigned to a learning Standard. */
    public string contentStandardName { get; set; }

    }
}
