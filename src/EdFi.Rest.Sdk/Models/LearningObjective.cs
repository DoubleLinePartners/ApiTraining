using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class LearningObjective {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* The designated title of the learning objective.   */
    public string objective { get; set; }

    /* The description of the content or subject area (e.g., arts, mathematics, reading, stenography, or a foreign language) of an assessment.   */
    public string academicSubjectDescriptor { get; set; }

    /* The grade level for which the learning objective is targeted,   */
    public string objectiveGradeLevelDescriptor { get; set; }

    /* The Identifier for the specific learning objective in the context of a standard (e.g., 111.15.3.1.A) */
    public string learningObjectiveId { get; set; }

    /* The description of the descriptor. */
    public string description { get; set; }

    /* The designated title of the learning objective.   */
    public string parentObjective { get; set; }

    /* The description of the content or subject area (e.g., arts, mathematics, reading, stenography, or a foreign language) of an assessment.   */
    public string parentAcademicSubjectDescriptor { get; set; }

    /* The grade level for which the learning objective is targeted,   */
    public string parentObjectiveGradeLevelDescriptor { get; set; }

    /* Reflects the specific nomenclature used for the Learning Objective. */
    public string nomenclature { get; set; }

    /* One or more statements that describes the criteria used by teachers and students to check for attainment of a leaning objective. This criteria gives clear indications as to the degree to which learning is moving through the Zone or Proximal Development toward independent achievement of the learning objective. */
    public string successCriteria { get; set; }

    /* This entity represents identified learning objectives for courses in specific grades. */
    public LearningObjectiveContentStandard contentStandard { get; set; }

    /* An unordered collection of learningObjectiveLearningStandards.  This entity represents identified learning objectives for courses in specific grades. */
    public List<LearningObjectiveLearningStandard> learningStandards { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
