using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class InterventionPrescription {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A reference to the related EducationOrganization resource. */
    public EducationOrganizationReference educationOrganizationReference { get; set; }

    /* A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. */
    public string identificationCode { get; set; }

    /* A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. */
    public string interventionClassType { get; set; }

    /* A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. */
    public string deliveryMethodType { get; set; }

    /*  */
    public string shortDescription { get; set; }

    /*  */
    public string description { get; set; }

    /* An unordered collection of interventionPrescriptionAppropriateGradeLevels.  Formal prescription of an instructional approach focusing on the specific techniques and materials used to teach a given subject. This can be prescribed by academic research, an interventions vendor or another entity. */
    public List<InterventionPrescriptionAppropriateGradeLevel> appropriateGradeLevels { get; set; }

    /* An unordered collection of interventionPrescriptionAppropriateSexes.  Formal prescription of an instructional approach focusing on the specific techniques and materials used to teach a given subject. This can be prescribed by academic research, an interventions vendor or another entity. */
    public List<InterventionPrescriptionAppropriateSex> appropriateSexes { get; set; }

    /* An unordered collection of interventionPrescriptionDiagnoses.  Formal prescription of an instructional approach focusing on the specific techniques and materials used to teach a given subject. This can be prescribed by academic research, an interventions vendor or another entity. */
    public List<InterventionPrescriptionDiagnosis> diagnoses { get; set; }

    /* An unordered collection of interventionPrescriptionEducationContents.  Formal prescription of an instructional approach focusing on the specific techniques and materials used to teach a given subject. This can be prescribed by academic research, an interventions vendor or another entity. */
    public List<InterventionPrescriptionEducationContent> educationContents { get; set; }

    /* An unordered collection of interventionPrescriptionLearningResourceMetadataURIs.  Formal prescription of an instructional approach focusing on the specific techniques and materials used to teach a given subject. This can be prescribed by academic research, an interventions vendor or another entity. */
    public List<InterventionPrescriptionLearningResourceMetadataURI> learningResourceMetadataURIs { get; set; }

    /* An unordered collection of interventionPrescriptionPopulationServeds.  Formal prescription of an instructional approach focusing on the specific techniques and materials used to teach a given subject. This can be prescribed by academic research, an interventions vendor or another entity. */
    public List<InterventionPrescriptionPopulationServed> populationServeds { get; set; }

    /* An unordered collection of interventionPrescriptionURIs.  Formal prescription of an instructional approach focusing on the specific techniques and materials used to teach a given subject. This can be prescribed by academic research, an interventions vendor or another entity. */
    public List<InterventionPrescriptionURI> uris { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
