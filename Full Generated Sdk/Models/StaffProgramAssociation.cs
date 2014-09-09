using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class StaffProgramAssociation {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A reference to the related Program resource. */
    public ProgramReference programReference { get; set; }

    /* A reference to the related Staff resource. */
    public StaffReference staffReference { get; set; }

    /* The month, day, and year on which the student first received services.  NEDM: Beginning Date   */
    public DateTime? beginDate { get; set; }

    /* The month, day, and year on which the student exited the program or stopped receiving services.  NEDM: Ending Date   */
    public DateTime? endDate { get; set; }

    /* Indicator of whether the staff has access to the student records of the program per district interpretation of FERPA and other privacy laws, regulations and policies. */
    public bool? studentRecordAccess { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
