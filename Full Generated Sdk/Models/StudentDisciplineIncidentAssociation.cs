using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class StudentDisciplineIncidentAssociation {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A reference to the related DisciplineIncident resource. */
    public DisciplineIncidentReference disciplineIncidentReference { get; set; }

    /* A reference to the related Student resource. */
    public StudentReference studentReference { get; set; }

    /* The role or type of participation of a student in a discipline incident; for example:  Victim  Perpetrator  Witness  Reporter   */
    public string studentParticipationCodeType { get; set; }

    /* An unordered collection of studentDisciplineIncidentAssociationBehaviors.  This association indicates those students who were victims, perpetrators, witnesses and/or reporters for a discipline incident. */
    public List<StudentDisciplineIncidentAssociationBehavior> behaviors { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
