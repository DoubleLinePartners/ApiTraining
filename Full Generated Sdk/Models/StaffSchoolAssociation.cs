using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class StaffSchoolAssociation {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A reference to the related School resource. */
    public SchoolReference schoolReference { get; set; }

    /* A reference to the related Staff resource. */
    public StaffReference staffReference { get; set; }

    /* The name of the program for which the individual is assigned; for example:  Regular education  Title I-Academic  Title I-Non-Academic  Special Education  Bilingual/English as a Second Language  NEDM: Program Assignment     */
    public string programAssignmentDescriptor { get; set; }

    /* Identifier for a school year */
    public int? schoolYear { get; set; }

    /* An unordered collection of staffSchoolAssociationAcademicSubjects.  This association indicates the school(s) to which a teacher provides instructional services. */
    public List<StaffSchoolAssociationAcademicSubject> academicSubjects { get; set; }

    /* An unordered collection of staffSchoolAssociationGradeLevels.  This association indicates the school(s) to which a teacher provides instructional services. */
    public List<StaffSchoolAssociationGradeLevel> gradeLevels { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
