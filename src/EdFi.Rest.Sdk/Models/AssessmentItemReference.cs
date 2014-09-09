using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class AssessmentItemReference {
    /* The title or name of the assessment.  NEDM: Assessment Title   */
    public string assessmentTitle { get; set; }

    /* The description of the content or subject area (e.g., arts, mathematics, reading, stenography, or a foreign language) of an assessment.  NEDM: Assessment Content, Academic Subject   */
    public string academicSubjectDescriptor { get; set; }

    /* The typical grade level for which an assessment is designed. If the test assessment spans a range of grades, then this attribute holds the highest grade assessed.  If only one grade level is assessed, then only this attribute is used. For example:  Adult  Prekindergarten  First grade  Second grade  ...   */
    public string assessedGradeLevelDescriptor { get; set; }

    /* The version identifier for the test assessment.  NEDM: Assessment Version   */
    public int? version { get; set; }

    /* A unique number or alphanumeric code assigned to a space, room, site, building, individual, organization, program, or institution by a school, school system, a state, or other agency or entity. */
    public string identificationCode { get; set; }

    /* Represents a hyperlink to the related assessmentItem resource. */
    public Link link { get; set; }

    }
}
