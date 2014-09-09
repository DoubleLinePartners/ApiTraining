using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class StudentElectronicMail {
    /* Key for ElectronicMail */
    public string electronicMailType { get; set; }

    /* The numbers, letters, and symbols used to identify an electronic mail (e-mail) user within the network to which the individual or organization belongs. */
    public string electronicMailAddress { get; set; }

    /* An indication that the electronic mail address should be used as the principal electronic mail address for an individual or organization. */
    public bool? primaryEmailAddressIndicator { get; set; }

    }
}
