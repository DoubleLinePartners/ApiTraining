using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class Assessment {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A reference to the related AssessmentFamily resource. */
    public AssessmentFamilyReference assessmentFamilyReference { get; set; }

    /* The title or name of the assessment.  NEDM: Assessment Title   */
    public string title { get; set; }

    /* The description of the content or subject area (e.g., arts, mathematics, reading, stenography, or a foreign language) of an assessment.  NEDM: Assessment Content, Academic Subject   */
    public string academicSubjectDescriptor { get; set; }

    /* The typical grade level for which an assessment is designed. If the test assessment spans a range of grades, then this attribute holds the highest grade assessed.  If only one grade level is assessed, then only this attribute is used. For example:  Adult  Prekindergarten  First grade  Second grade  ...   */
    public string assessedGradeLevelDescriptor { get; set; }

    /* The version identifier for the test assessment.  NEDM: Assessment Version   */
    public int? version { get; set; }

    /* The category of an assessment based on format and content. For example:  Achievement test  ACT  Advanced placement test  Alternate assessment/grade-level standards  Attitudinal test  Benchmark test  Cognitive and perceptual skills test  SAT  TAKS    ...  NEDM: Assessment Type   */
    public string categoryType { get; set; }

    /* If the test assessment spans a range of grades, then this attribute holds the lowest grade assessed.  If only one grade level is assessed, then this attribute is omitted. For example:  Adult  Prekindergarten  First grade  Second grade  ...   */
    public string lowestAssessedGradeLevelDescriptor { get; set; }

    /* Identifies the form of the assessment, for example a regular versus makeup form, multiple choice versus constructed response, etc. */
    public string form { get; set; }

    /* The month, day, and year that the conceptual design for the assessment was most recently revised substantially.  NEDM: Date Of Assessment Revision   */
    public DateTime? revisionDate { get; set; }

    /* The maximum raw score achievable across all assessment items that are correct and scored at the maximum.   */
    public int? maxRawScore { get; set; }

    /* Reflects the specific nomenclature used for Assessment. */
    public string nomenclature { get; set; }

    /* The period or window in which an assessment is supposed to be administered. */
    public string periodDescriptor { get; set; }

    /* This entity represents a tool, instrument, process or exhibition composed of a systematic sampling of behavior for measuring a student's competence, knowledge, skills or behavior. An assessment can be used to measure differences in individuals or groups and changes in performance from one occasion to the next. */
    public AssessmentContentStandard contentStandard { get; set; }

    /* An unordered collection of assessmentIdentificationCodes.  This entity represents a tool, instrument, process or exhibition composed of a systematic sampling of behavior for measuring a student's competence, knowledge, skills or behavior. An assessment can be used to measure differences in individuals or groups and changes in performance from one occasion to the next. */
    public List<AssessmentIdentificationCode> identificationCodes { get; set; }

    /* An unordered collection of assessmentLanguages.  This entity represents a tool, instrument, process or exhibition composed of a systematic sampling of behavior for measuring a student's competence, knowledge, skills or behavior. An assessment can be used to measure differences in individuals or groups and changes in performance from one occasion to the next. */
    public List<AssessmentLanguage> languages { get; set; }

    /* An unordered collection of assessmentPerformanceLevels.  This entity represents a tool, instrument, process or exhibition composed of a systematic sampling of behavior for measuring a student's competence, knowledge, skills or behavior. An assessment can be used to measure differences in individuals or groups and changes in performance from one occasion to the next. */
    public List<AssessmentPerformanceLevel> performanceLevels { get; set; }

    /* An unordered collection of assessmentPrograms.  This entity represents a tool, instrument, process or exhibition composed of a systematic sampling of behavior for measuring a student's competence, knowledge, skills or behavior. An assessment can be used to measure differences in individuals or groups and changes in performance from one occasion to the next. */
    public List<AssessmentProgram> programs { get; set; }

    /* An unordered collection of assessmentScores.  This entity represents a tool, instrument, process or exhibition composed of a systematic sampling of behavior for measuring a student's competence, knowledge, skills or behavior. An assessment can be used to measure differences in individuals or groups and changes in performance from one occasion to the next. */
    public List<AssessmentScore> scores { get; set; }

    /* An unordered collection of assessmentSections.  This entity represents a tool, instrument, process or exhibition composed of a systematic sampling of behavior for measuring a student's competence, knowledge, skills or behavior. An assessment can be used to measure differences in individuals or groups and changes in performance from one occasion to the next. */
    public List<AssessmentSection> sections { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
