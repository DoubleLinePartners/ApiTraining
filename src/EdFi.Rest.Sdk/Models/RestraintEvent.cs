using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class RestraintEvent {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A reference to the related School resource. */
    public SchoolReference schoolReference { get; set; }

    /* A reference to the related Student resource. */
    public StudentReference studentReference { get; set; }

    /* A unique number or alphanumeric code assigned to a restraint event by a school, school system, a state, or other agency or entity.   */
    public string identifier { get; set; }

    /* Month, day and year of the resteraint event.   */
    public DateTime? eventDate { get; set; }

    /* The setting where the restrint was exercised..   */
    public string educationalEnvironmentType { get; set; }

    /* An unordered collection of restraintEventPrograms.  This event entity represents the instances where a special education student was physically or mechanically restrained due to imminent serious physical harm to themselves or others, imminent serious property destruction or a combination of both imminent serious physical harm to themselves or others and imminent serious property destruction. */
    public List<RestraintEventProgram> programs { get; set; }

    /* An unordered collection of restraintEventReasons.  This event entity represents the instances where a special education student was physically or mechanically restrained due to imminent serious physical harm to themselves or others, imminent serious property destruction or a combination of both imminent serious physical harm to themselves or others and imminent serious property destruction. */
    public List<RestraintEventReason> reasons { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
