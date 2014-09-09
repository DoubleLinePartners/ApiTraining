using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class ParentTelephone {
    /* Key for TelephoneNumber */
    public string telephoneNumberType { get; set; }

    /* The order of priority assigned to telephone numbers to define which number to attempt first, second, etc. */
    public int? orderOfPriority { get; set; }

    /* An indication that the telephone number is technically capable of sending and receiving Short Message Service (SMS) text messages. */
    public bool? textMessageCapabilityIndicator { get; set; }

    /* The 10-digit telephone number, including the area code, for the person. */
    public string telephoneNumber { get; set; }

    }
}
