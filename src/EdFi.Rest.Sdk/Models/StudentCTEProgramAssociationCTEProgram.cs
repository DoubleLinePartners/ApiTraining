using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class StudentCTEProgramAssociationCTEProgram {
    /* The career cluster representing the career path of the Vocational/Career Tech concentrator.  NEDM: Career Cluster     */
    public string careerPathwayType { get; set; }

    /* Number and description of the CIP Code associated with the student   s CTE program. */
    public string cipCode { get; set; }

    /* A Boolean indicator of whether this CTE program, is the student   s primary CTE program. */
    public bool? primaryCTEProgramIndicator { get; set; }

    /* A Boolean indicator of whether the student has completed the CTE program. */
    public bool? cteProgramCompletionIndicator { get; set; }

    }
}
