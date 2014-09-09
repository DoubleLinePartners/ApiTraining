using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class AssessmentItem {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A reference to the related Assessment resource. */
    public AssessmentReference assessmentReference { get; set; }

    /* A unique number or alphanumeric code assigned to a space, room, site, building, individual, organization, program, or institution by a school, school system, a state, or other agency or entity. */
    public string identificationCode { get; set; }

    /* Category or type of the assessment item.  For example:  Multiple choice  Analytic  Prose  ....     */
    public string categoryType { get; set; }

    /* The maximum raw score achievable is all assessment items are correct and scored at the maximum.   */
    public int? maxRawScore { get; set; }

    /* The correct response for the assessment item.   */
    public string correctResponse { get; set; }

    /* The duration of time allotted for the assessment item. */
    public string expectedTimeAssessed { get; set; }

    /* Reflects the specific nomenclature used for AssessmentItem. */
    public string nomenclature { get; set; }

    /* An unordered collection of assessmentItemLearningStandards.  This entity represents one of many single measures that make up an assessment. */
    public List<AssessmentItemLearningStandard> learningStandards { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
