using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class StudentProgramAssociationReference {
    /* A unique alpha-numeric code assigned to a student. */
    public string studentUniqueId { get; set; }

    /* The program associated with the student. */
    public string programType { get; set; }

    /* The formal name of the program of instruction, training, services or benefits available through federal, state, or local agencies. */
    public string programName { get; set; }

    /* The education organization where the student is participating in or receiving the program services. */
    public int? programEducationOrganizationId { get; set; }

    /* The month, day, and year on which the student first received services.  NEDM: Beginning Date */
    public DateTime? beginDate { get; set; }

    /*  */
    public int? educationOrganizationId { get; set; }

    /* Represents a hyperlink to the related studentProgramAssociation resource. */
    public Link link { get; set; }

    }
}
