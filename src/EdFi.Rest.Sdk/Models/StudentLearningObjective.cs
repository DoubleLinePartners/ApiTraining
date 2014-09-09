using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class StudentLearningObjective {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A reference to the related GradingPeriod resource. */
    public GradingPeriodReference gradingPeriodReference { get; set; }

    /* A reference to the related LearningObjective resource. */
    public LearningObjectiveReference learningObjectiveReference { get; set; }

    /* A reference to the related StudentProgramAssociation resource. */
    public StudentProgramAssociationReference studentProgramAssociationReference { get; set; }

    /* A reference to the related StudentSectionAssociation resource. */
    public StudentSectionAssociationReference studentSectionAssociationReference { get; set; }

    /* The competency level assessed for the student for the referenced learning objective. */
    public string competencyLevelDescriptor { get; set; }

    /* A statement provided by the teacher that provides information in addition to the grade or assessment score. */
    public string diagnosticStatement { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
