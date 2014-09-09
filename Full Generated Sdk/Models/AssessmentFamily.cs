using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class AssessmentFamily {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* The title or name of the assessment family. */
    public string title { get; set; }

    /* Key for AcademicSubject */
    public string academicSubjectDescriptor { get; set; }

    /* Key for GradeLevel */
    public string assessedGradeLevelDescriptor { get; set; }

    /* The version identifier for the assessment family. */
    public int? version { get; set; }

    /* Key for AssessmentCategoryType */
    public string assessmentCategoryType { get; set; }

    /* Key for GradeLevel */
    public string lowestAssessedGradeLevelDescriptor { get; set; }

    /* The month, day, and year that the conceptual design for the assessment family was most recently revised substantially. */
    public DateTime? revisionDate { get; set; }

    /* Reflects the specific nomenclature used for this level of AssessmentFamily. */
    public string nomenclature { get; set; }

    /* The title or name of the assessment family. */
    public string parentAssessmentFamilyTitle { get; set; }

    /* This entity represents a logical grouping or association of assessments that share a common purpose, heritage or content standard. There may be hierarchies of Assessment Families. Characteristics (e.g., Academic Subject) specified for AssessmentFamilies, by convention, are inherited by the Assessments associated with the AssessmentFamily. */
    public AssessmentFamilyContentStandard contentStandard { get; set; }

    /* An unordered collection of assessmentFamilyAssessmentPeriods.  This entity represents a logical grouping or association of assessments that share a common purpose, heritage or content standard. There may be hierarchies of Assessment Families. Characteristics (e.g., Academic Subject) specified for AssessmentFamilies, by convention, are inherited by the Assessments associated with the AssessmentFamily. */
    public List<AssessmentFamilyAssessmentPeriod> assessmentPeriods { get; set; }

    /* An unordered collection of assessmentFamilyIdentificationCodes.  This entity represents a logical grouping or association of assessments that share a common purpose, heritage or content standard. There may be hierarchies of Assessment Families. Characteristics (e.g., Academic Subject) specified for AssessmentFamilies, by convention, are inherited by the Assessments associated with the AssessmentFamily. */
    public List<AssessmentFamilyIdentificationCode> identificationCodes { get; set; }

    /* An unordered collection of assessmentFamilyLanguages.  This entity represents a logical grouping or association of assessments that share a common purpose, heritage or content standard. There may be hierarchies of Assessment Families. Characteristics (e.g., Academic Subject) specified for AssessmentFamilies, by convention, are inherited by the Assessments associated with the AssessmentFamily. */
    public List<AssessmentFamilyLanguage> languages { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
