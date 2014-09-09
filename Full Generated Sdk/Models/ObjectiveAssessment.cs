using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class ObjectiveAssessment {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A reference to the related Assessment resource. */
    public AssessmentReference assessmentReference { get; set; }

    /* A unique number or alphanumeric code assigned to a space, room, site, building, individual, organization, program, or institution by a school, school system, a state, or other agency or entity. */
    public string identificationCode { get; set; }

    /*  */
    public string parentIdentificationCode { get; set; }

    /* The maximum raw score achievable across all assessment items for the objective that are correct and scored at the maximum. */
    public int? maxRawScore { get; set; }

    /* The percent of the assessment that tests this objective. */
    public double? percentOfAssessment { get; set; }

    /* Reflects the specific nomenclature used for this level of ObjectiveAssessment. */
    public string nomenclature { get; set; }

    /* The description of the objective assessment (e.g., vocabulary, measurement, or geometry). */
    public string description { get; set; }

    /* An unordered collection of objectiveAssessmentAssessmentItems.  This entity represents subtests that assess specific learning objectives. */
    public List<ObjectiveAssessmentAssessmentItem> assessmentItems { get; set; }

    /* An unordered collection of objectiveAssessmentLearningObjectives.  This entity represents subtests that assess specific learning objectives. */
    public List<ObjectiveAssessmentLearningObjective> learningObjectives { get; set; }

    /* An unordered collection of objectiveAssessmentLearningStandards.  This entity represents subtests that assess specific learning objectives. */
    public List<ObjectiveAssessmentLearningStandard> learningStandards { get; set; }

    /* An unordered collection of objectiveAssessmentPerformanceLevels.  This entity represents subtests that assess specific learning objectives. */
    public List<ObjectiveAssessmentPerformanceLevel> performanceLevels { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
