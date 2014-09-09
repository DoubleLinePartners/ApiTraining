using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class DisciplineAction {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A reference to the related School resource. */
    public SchoolReference assignmentSchoolReference { get; set; }

    /* A reference to the related School resource. */
    public SchoolReference responsibilitySchoolReference { get; set; }

    /* A reference to the related Student resource. */
    public StudentReference studentReference { get; set; }

    /* Identifier assigned by the education organization to the discipline action. */
    public string identifier { get; set; }

    /* Month, day and year of the discipline action. */
    public DateTime? disciplineDate { get; set; }

    /* The length of time in school days for the Discipline Action (e.g. removal, detention), if applicable. */
    public int? length { get; set; }

    /* The length of time in school days for the Discipline Action (e.g. removal, detention), if applicable. */
    public int? actualDisciplineActionLength { get; set; }

    /* Key for DisciplineActionLengthDifferenceReason */
    public string lengthDifferenceReasonType { get; set; }

    /* An indication of whether or not this disciplinary action taken against a student was imposed as a consequence of state or local zero tolerance policies. */
    public bool? relatedToZeroTolerancePolicy { get; set; }

    /*  */
    public DateTime? disciplineEndDate { get; set; }

    /*  */
    public string specialEdModifiedIndicator { get; set; }

    /*  */
    public string specialEdAuthorityDescriptor { get; set; }

    /*  */
    public string disciplinaryReasonDescriptor { get; set; }

    /* An unordered collection of disciplineActionDisciplines.  This event entity represents actions taken by an education organization after a disruptive event that is recorded as a discipline incident. */
    public List<DisciplineActionDiscipline> disciplines { get; set; }

    /* An unordered collection of disciplineActionDisciplineIncidents.  This event entity represents actions taken by an education organization after a disruptive event that is recorded as a discipline incident. */
    public List<DisciplineActionDisciplineIncident> disciplineIncidents { get; set; }

    /* An unordered collection of disciplineActionStaffs.  This event entity represents actions taken by an education organization after a disruptive event that is recorded as a discipline incident. */
    public List<DisciplineActionStaff> staffs { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
