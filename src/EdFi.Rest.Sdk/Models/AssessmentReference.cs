using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class AssessmentReference {
    /* The title or name of the assessment.  NEDM: Assessment Title   */
    public string title { get; set; }

    /* The description of the content or subject area (e.g., arts, mathematics, reading, stenography, or a foreign language) of an assessment.  NEDM: Assessment Content, Academic Subject   */
    public string academicSubjectDescriptor { get; set; }

    /* The typical grade level for which an assessment is designed. If the test assessment spans a range of grades, then this attribute holds the highest grade assessed.  If only one grade level is assessed, then only this attribute is used. For example:  Adult  Prekindergarten  First grade  Second grade  ...   */
    public string assessedGradeLevelDescriptor { get; set; }

    /* The version identifier for the test assessment.  NEDM: Assessment Version   */
    public int? version { get; set; }

    /* Represents a hyperlink to the related assessment resource. */
    public Link link { get; set; }

    }
}
