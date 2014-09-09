using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class InterventionStudy {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A reference to the related EducationOrganization resource. */
    public EducationOrganizationReference educationOrganizationReference { get; set; }

    /* A reference to the related InterventionPrescription resource. */
    public InterventionPrescriptionReference interventionPrescriptionReference { get; set; }

    /* A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. */
    public string identificationCode { get; set; }

    /* The number of participants observed in the study. */
    public int? participants { get; set; }

    /* A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. */
    public string deliveryMethodType { get; set; }

    /* A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. */
    public string interventionClassType { get; set; }

    /*  */
    public string shortDescription { get; set; }

    /*  */
    public string description { get; set; }

    /* An unordered collection of interventionStudyAppropriateGradeLevels.  An experimental or quasi-experimental study of an intervention technique. */
    public List<InterventionStudyAppropriateGradeLevel> appropriateGradeLevels { get; set; }

    /* An unordered collection of interventionStudyAppropriateSexes.  An experimental or quasi-experimental study of an intervention technique. */
    public List<InterventionStudyAppropriateSex> appropriateSexes { get; set; }

    /* An unordered collection of interventionStudyEducationContents.  An experimental or quasi-experimental study of an intervention technique. */
    public List<InterventionStudyEducationContent> educationContents { get; set; }

    /* An unordered collection of interventionStudyInterventionEffectivenesses.  An experimental or quasi-experimental study of an intervention technique. */
    public List<InterventionStudyInterventionEffectiveness> interventionEffectivenesses { get; set; }

    /* An unordered collection of interventionStudyLearningResourceMetadataURIs.  An experimental or quasi-experimental study of an intervention technique. */
    public List<InterventionStudyLearningResourceMetadataURI> learningResourceMetadataURIs { get; set; }

    /* An unordered collection of interventionStudyPopulationServeds.  An experimental or quasi-experimental study of an intervention technique. */
    public List<InterventionStudyPopulationServed> populationServeds { get; set; }

    /* An unordered collection of interventionStudyStateAbbreviations.  An experimental or quasi-experimental study of an intervention technique. */
    public List<InterventionStudyStateAbbreviation> stateAbbreviations { get; set; }

    /* An unordered collection of interventionStudyURIs.  An experimental or quasi-experimental study of an intervention technique. */
    public List<InterventionStudyURI> uris { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
