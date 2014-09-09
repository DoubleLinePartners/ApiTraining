using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class LearningStandard {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* The Identifier for the specific learning standard (e.g., 111.15.3.1.A) */
    public string learningStandardId { get; set; }

    /* The Identifier for the specific learning standard (e.g., 111.15.3.1.A) */
    public string parentLearningStandardId { get; set; }

    /* The description of the descriptor. */
    public string description { get; set; }

    /* A code designated by the promulgating body to identify the statement, e.g. 1.N.3 (usually not globally unique). */
    public string itemCode { get; set; }

    /* An unambiguous reference to the statement using a network-resolvable URI. */
    public string uri { get; set; }

    /* The grade level for the specific learning standard. */
    public string gradeLevelDescriptor { get; set; }

    /* Subject area for the learning standard. */
    public string academicSubjectDescriptor { get; set; }

    /* The official Course Title with which this learning standard is associated. */
    public string courseTitle { get; set; }

    /* One or more statements that describes the criteria used by teachers and students to check for attainment of a leaning objective. This criteria gives clear indications as to the degree to which learning is moving through the Zone or Proximal Development toward independent achievement of the learning objective. */
    public string successCriteria { get; set; }

    /* This entity is a sub-element of a learning objective consisting of a precise statement of the expectation of a student's proficiency. */
    public LearningStandardContentStandard contentStandard { get; set; }

    /* An unordered collection of learningStandardIdentificationCodes.  This entity is a sub-element of a learning objective consisting of a precise statement of the expectation of a student's proficiency. */
    public List<LearningStandardIdentificationCode> identificationCodes { get; set; }

    /* An unordered collection of learningStandardPrerequisiteLearningStandards.  This entity is a sub-element of a learning objective consisting of a precise statement of the expectation of a student's proficiency. */
    public List<LearningStandardPrerequisiteLearningStandard> prerequisiteLearningStandards { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
