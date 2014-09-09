using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class DisciplineIncident {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A reference to the related School resource. */
    public SchoolReference schoolReference { get; set; }

    /* A reference to the related Staff resource. */
    public StaffReference staffReference { get; set; }

    /* A locally assigned unique identifier (within the school or school district) to identify each specific incident or occurrence. The same identifier should be used to document the entire incident even if it included multiple offenses and multiple offenders.   */
    public string incidentIdentifier { get; set; }

    /* The month, day, and year on which the incident occurred.    */
    public DateTime? incidentDate { get; set; }

    /* An indication of the time of day the incident took place.   */
    public string incidentTime { get; set; }

    /* Identifies where the incident occurred and whether or not it occurred on campus, for example:  On campus  Administrative offices area  Cafeteria area  Classroom  Hallway or stairs  ...   */
    public string incidentLocationType { get; set; }

    /* Information on the type of individual who reported the incident. When known and/or if useful, use a more specific option code (e.g., ""Counselor"" rather than ""Professional Staff""); for example:Student  Parent/guardian  Law enforcement officer  Nonschool personnel  Representative of visiting school  ...   */
    public string reporterDescriptionDescriptor { get; set; }

    /* Identifies the reporter of the incident by name.   */
    public string reporterName { get; set; }

    /* Indicator of whether the incident was reported to law enforcement.   */
    public bool? reportedToLawEnforcement { get; set; }

    /* The case number assigned to the incident by law enforcement or other organization.   */
    public string caseNumber { get; set; }

    /* The description for an incident. */
    public string incidentDescription { get; set; }

    /* The value of any quantifiable monetary loss directly resulting from the incident. Examples include the value of repairs necessitated by vandalism of a school facility, the value of personnel resources used for repairs or consumed by the incident. */
    public double? incidentCost { get; set; }

    /* An unordered collection of disciplineIncidentBehaviors.  This event entity represents an occurrence of an infraction ranging from a minor behavioral problem that disrupts the orderly functioning of a school or classroom (such as tardiness) to a criminal act that results in the involvement of a law enforcement official (such as robbery). A single event (e.g., a fight) is one incident regardless of how many perpetrators or victims are involved. Discipline incidents are events classified as warranting discipline action. */
    public List<DisciplineIncidentBehavior> behaviors { get; set; }

    /* An unordered collection of disciplineIncidentWeapons.  This event entity represents an occurrence of an infraction ranging from a minor behavioral problem that disrupts the orderly functioning of a school or classroom (such as tardiness) to a criminal act that results in the involvement of a law enforcement official (such as robbery). A single event (e.g., a fight) is one incident regardless of how many perpetrators or victims are involved. Discipline incidents are events classified as warranting discipline action. */
    public List<DisciplineIncidentWeapon> weapons { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
