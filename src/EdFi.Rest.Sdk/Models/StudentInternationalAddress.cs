using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class StudentInternationalAddress {
    /* Key for Address */
    public string addressType { get; set; }

    /* Any number of address lines associated with an international address. */
    public string addressLine1 { get; set; }

    /* Any number of address lines associated with an international address. */
    public string addressLine2 { get; set; }

    /* Any number of address lines associated with an international address. */
    public string addressLine3 { get; set; }

    /* Any number of address lines associated with an international address. */
    public string addressLine4 { get; set; }

    /* The geographic latitude of the physical address. */
    public string latitude { get; set; }

    /* The geographic longitude of the physical address. */
    public string longitude { get; set; }

    /* The first date the address is valid.  For physical addresses, the date the person moved to that address. */
    public DateTime? beginDate { get; set; }

    /* The last date the address is valid.  For physical addresses, this would be the date the person moved from that address. */
    public DateTime? endDate { get; set; }

    /*  */
    public string countryType { get; set; }

    }
}
