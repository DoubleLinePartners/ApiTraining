using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class StaffIdentificationCode {
    /* Key for StaffIdentificationSystem */
    public string staffIdentificationSystemType { get; set; }

    /* The organization code or name assigning the Staff Identification Code. */
    public string assigningOrganizationIdentificationCode { get; set; }

    /* A unique number or alphanumeric code assigned to a staff member by a school, school system, a state, or other agency or entity. */
    public string identificationCode { get; set; }

    }
}
