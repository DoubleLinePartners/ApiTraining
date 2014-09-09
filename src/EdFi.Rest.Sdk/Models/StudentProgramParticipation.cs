using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class StudentProgramParticipation {
    /* The program the student is associated with or receiving services from. */
    public string programType { get; set; }

    /* The date the student was associated with the program or service. */
    public DateTime? beginDate { get; set; }

    /* The month, day, and year on which the student exited the program or stopped receiving services. */
    public DateTime? endDate { get; set; }

    /* The person, organization, or department that designated the program association. */
    public string designatedBy { get; set; }

    /* An unordered collection of studentProgramParticipationProgramCharacteristics.  Key programs the student is participating in or receives services from. */
    public List<StudentProgramParticipationProgramCharacteristic> programCharacteristics { get; set; }

    }
}
