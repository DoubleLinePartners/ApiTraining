using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class StudentProgramAssociation {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A reference to the related EducationOrganization resource. */
    public EducationOrganizationReference educationOrganizationReference { get; set; }

    /* A reference to the related Program resource. */
    public ProgramReference programReference { get; set; }

    /* A reference to the related Student resource. */
    public StudentReference studentReference { get; set; }

    /* The month, day, and year on which the student first received services.  NEDM: Beginning Date */
    public DateTime? beginDate { get; set; }

    /* The month, day, and year on which the student exited the program or stopped receiving services.  NEDM: Ending Date */
    public DateTime? endDate { get; set; }

    /* A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. */
    public string reasonExitedDescriptor { get; set; }

    /* Indicates whether the student received services during the summer session or between sessions. */
    public bool? servedOutsideOfRegularSession { get; set; }

    /* An unordered collection of studentProgramAssociationServices.  This association represents the program(s) that a student participates in or is served by. */
    public List<StudentProgramAssociationService> services { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
