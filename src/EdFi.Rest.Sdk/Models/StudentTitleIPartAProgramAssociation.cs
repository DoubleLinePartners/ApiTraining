using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class StudentTitleIPartAProgramAssociation {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A unique alpha-numeric code assigned to a student. */
    public string studentUniqueId { get; set; }

    /* The program associated with the student. */
    public string programType { get; set; }

    /* The education organization where the student is participating in or receiving the program services. */
    public int? programEducationOrganizationId { get; set; }

    /* The month, day, and year on which the student first received services.  NEDM: Beginning Date   */
    public DateTime? beginDate { get; set; }

    /* The formal name of the program of instruction, training, services or benefits available through federal, state, or local agencies. */
    public string programName { get; set; }

    /* The education organization where the student is participating in or receiving the program services. */
    public int? educationOrganizationId { get; set; }

    /* The month, day, and year on which the student exited the program or stopped receiving services.  NEDM: Ending Date */
    public DateTime? endDate { get; set; }

    /* A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. */
    public string reasonExitedDescriptor { get; set; }

    /* Indicates whether the student received services during the summer session or between sessions. */
    public bool? servedOutsideOfRegularSession { get; set; }

    /* An indication of the type of Title I program, if any, in which the student is participating and served:  Public Targeted Assistance Program  Public Schoolwide Program  Private school student participating  Local Neglected Program  NEDM: Title I Participlant   */
    public string titleIPartAParticipantType { get; set; }

    /* An unordered collection of studentProgramAssociationServices.  This association represents the Title I Part A program(s) that a student participates in or from which the student receives services. The association is an extension of the StudentProgramAssociation particular for Title I Part A programs. */
    public List<StudentProgramAssociationService> services { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
