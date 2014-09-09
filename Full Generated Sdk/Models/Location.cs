using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class Location {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A reference to the related School resource. */
    public SchoolReference schoolReference { get; set; }

    /* A unique number or alphanumeric code assigned to a room by a school, school system, state, or other agency or entity.   */
    public string classroomIdentificationCode { get; set; }

    /* The most number of seats the class can maintain.   */
    public int? maximumNumberOfSeats { get; set; }

    /* The number of seats that is most favorable to the class.   */
    public int? optimalNumberOfSeats { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
