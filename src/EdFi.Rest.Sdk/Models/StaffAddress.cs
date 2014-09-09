using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class StaffAddress {
    /* Key for Address */
    public string addressType { get; set; }

    /* The street number and street name or post office box number of an address.   */
    public string streetNumberName { get; set; }

    /* The apartment, room, or suite number of an address.    */
    public string apartmentRoomSuiteNumber { get; set; }

    /* The number of the building on the site, if more than one building shares the same address.   */
    public string buildingSiteNumber { get; set; }

    /* The name of the city in which an address is located.    */
    public string city { get; set; }

    /* The abbreviation for the state (within the United States) or outlying area in which an address is located.    */
    public string stateAbbreviationType { get; set; }

    /* The five or nine digit zip code portion of an address.   */
    public string postalCode { get; set; }

    /* The name of the county, parish, borough, or comparable unit (within a state) in which an address is located.   */
    public string nameOfCounty { get; set; }

    /* 5 digit code consisting of the two digit state code followed by the three digit FIPS code for the county.   */
    public string countyFIPSCode { get; set; }

    /* The geographic latitude of the physical address. */
    public string latitude { get; set; }

    /* The geographic longitude of the physical aaddress. */
    public string longitude { get; set; }

    /* The first date the address is valid.  For physical addresses, the date the person moved to that address. */
    public DateTime? beginDate { get; set; }

    /* The last date the address is valid.  For physical addresses, this would be the date the person moved from that address. */
    public DateTime? endDate { get; set; }

    }
}
