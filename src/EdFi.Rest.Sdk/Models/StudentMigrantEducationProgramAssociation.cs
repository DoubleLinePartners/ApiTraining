using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class StudentMigrantEducationProgramAssociation {
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

    /* Report migratory children who are classified as having  priority for services  because they are failing, or most at risk of failing to meet the State s challenging State academic content standards and challenging State student academic achievement standards, and their education has been interrupted during the regular school year. */
    public bool? priorityForServices { get; set; }

    /* Date the last qualifying move occurred; used to compute MEP status. */
    public DateTime? lastQualifyingMove { get; set; }

    /* A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. */
    public string continuationOfServicesReasonDescriptor { get; set; }

    /* The month, day, and year on which the student first entered the US. */
    public DateTime? usInitialEntry { get; set; }

    /* The month, day, and year of the student's most recent entry into the US. */
    public DateTime? usMostRecentEntry { get; set; }

    /* The month, day, and year on which the student first entered a US School. */
    public DateTime? usInitialSchoolEntry { get; set; }

    /* An unordered collection of studentProgramAssociationServices.  This association represents the migrant education program(s) that a student participates in or receives services from. The association is an extension of the StudentProgramAssociation with added elements particular to migrant education programs. */
    public List<StudentProgramAssociationService> services { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
