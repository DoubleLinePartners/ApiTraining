using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class StudentParentAssociation {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A reference to the related Parent resource. */
    public ParentReference parentReference { get; set; }

    /* A reference to the related Student resource. */
    public StudentReference studentReference { get; set; }

    /* The nature of an individual''s relationship to a student; for example:  Father  Mother  Step Father  Step Mother  Foster Father  Foster Mother  Guardian  ...  NEDM: Relationship to Student   */
    public string relationType { get; set; }

    /* Indicator of whether the person is a primary parental contact for the student.   */
    public bool? primaryContactStatus { get; set; }

    /* Indicator of whether the student lives with the associated parent.   */
    public bool? livesWith { get; set; }

    /* Indicator of whether the person is a designated emergency contact for the student.   */
    public bool? emergencyContactStatus { get; set; }

    /* The numeric order of the preferred sequence or priority of contact. */
    public int? contactPriority { get; set; }

    /* Restrictions for student and/or teacher contact with the individual (e.g., the student may not be picked up by the individual) */
    public string contactRestrictions { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
