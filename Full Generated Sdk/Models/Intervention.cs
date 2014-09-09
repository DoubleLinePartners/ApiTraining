using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class Intervention {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A reference to the related EducationOrganization resource. */
    public EducationOrganizationReference educationOrganizationReference { get; set; }

    /* A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. */
    public string identificationCode { get; set; }

    /* A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. */
    public string classType { get; set; }

    /* A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. */
    public string deliveryMethodType { get; set; }

    /* The start date for the intervention implementation. */
    public DateTime? beginDate { get; set; }

    /* The end date for the intervention implementation. */
    public DateTime? endDate { get; set; }

    /*  */
    public string shortDescription { get; set; }

    /*  */
    public string description { get; set; }

    /* An unordered collection of interventionAppropriateGradeLevels.  An implementation of an instructional approach focusing on the specific techniques and materials used to teach a given subject. */
    public List<InterventionAppropriateGradeLevel> appropriateGradeLevels { get; set; }

    /* An unordered collection of interventionAppropriateSexes.  An implementation of an instructional approach focusing on the specific techniques and materials used to teach a given subject. */
    public List<InterventionAppropriateSex> appropriateSexes { get; set; }

    /* An unordered collection of interventionDiagnoses.  An implementation of an instructional approach focusing on the specific techniques and materials used to teach a given subject. */
    public List<InterventionDiagnosis> diagnoses { get; set; }

    /* An unordered collection of interventionEducationContents.  An implementation of an instructional approach focusing on the specific techniques and materials used to teach a given subject. */
    public List<InterventionEducationContent> educationContents { get; set; }

    /* An unordered collection of interventionInterventionPrescriptions.  An implementation of an instructional approach focusing on the specific techniques and materials used to teach a given subject. */
    public List<InterventionInterventionPrescription> interventionPrescriptions { get; set; }

    /* An unordered collection of interventionLearningResourceMetadataURIs.  An implementation of an instructional approach focusing on the specific techniques and materials used to teach a given subject. */
    public List<InterventionLearningResourceMetadataURI> learningResourceMetadataURIs { get; set; }

    /* An unordered collection of interventionMeetingTimes.  An implementation of an instructional approach focusing on the specific techniques and materials used to teach a given subject. */
    public List<InterventionMeetingTime> meetingTimes { get; set; }

    /* An unordered collection of interventionPopulationServeds.  An implementation of an instructional approach focusing on the specific techniques and materials used to teach a given subject. */
    public List<InterventionPopulationServed> populationServeds { get; set; }

    /* An unordered collection of interventionStaffs.  An implementation of an instructional approach focusing on the specific techniques and materials used to teach a given subject. */
    public List<InterventionStaff> staffs { get; set; }

    /* An unordered collection of interventionURIs.  An implementation of an instructional approach focusing on the specific techniques and materials used to teach a given subject. */
    public List<InterventionURI> uris { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
