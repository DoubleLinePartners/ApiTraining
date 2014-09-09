using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class StudentSpecialEducationProgramAssociation {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A unique alpha-numeric code assigned to a student. */
    public string studentUniqueId { get; set; }

    /* The program associated with the student. */
    public string programType { get; set; }

    /* The education organization where the student is participating in or receiving the program services. */
    public int? programEducationOrganizationId { get; set; }

    /* The month, day, and year on which the student first received services.  NEDM: Beginning Date   */
    public DateTime? beginDate { get; set; }

    /* The formal name of the program of instruction, training, services or benefits available through federal, state, or local agencies. */
    public string programName { get; set; }

    /* The education organization where the student is participating in or receiving the program services. */
    public int? educationOrganizationId { get; set; }

    /* The month, day, and year on which the student exited the program or stopped receiving services.  NEDM: Ending Date */
    public DateTime? endDate { get; set; }

    /* A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. */
    public string reasonExitedDescriptor { get; set; }

    /* Indicates whether the student received services during the summer session or between sessions. */
    public bool? servedOutsideOfRegularSession { get; set; }

    /* Indicator of the eligibility of the student to receive special education services according to the Individuals with Disabilities Education Act (IDEA). */
    public bool? ideaEligibility { get; set; }

    /* A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. */
    public string specialEducationSettingDescriptor { get; set; }

    /* The number of hours per week for special education instruction and therapy */
    public double? specialEducationHoursPerWeek { get; set; }

    /* Indicate the total number of hours of instructional time per week for the school that the student attends. */
    public double? schoolHoursPerWeek { get; set; }

    /* Indicates whether the student receiving special education and related services has been designated as multiply disabled by the admission, review, and dismissal committee. [See 19 TAC A 89.1040(c)(6).]   */
    public bool? multiplyDisabled { get; set; }

    /* Indicates whether the student receiving special education and related services is:  1) in the age range of birth to 22 years, and  2) has a serious, ongoing illness or a chronic condition that has lasted or is anticipated to last at least 12 or more months or has required at least one month of hospitalization, and that requires daily, ongoing medical treatments and monitoring by appropriately trained personnel which may include parents or other family members, and  3) requires the routine use of medical device or of assistive technology to compensate for the loss of usefulness of a body function needed to participate in activities of daily living, and  4) lives with ongoing threat to his or her continued well-being.   */
    public bool? medicallyFragile { get; set; }

    /* The date of the last special education evaluation. */
    public DateTime? lastEvaluationDate { get; set; }

    /* The date of the last IEP review. */
    public DateTime? iepReviewDate { get; set; }

    /* The effective date of the most recent IEP */
    public DateTime? iepBeginDate { get; set; }

    /* The end date of the most recent IEP */
    public DateTime? iepEndDate { get; set; }

    /*  */
    public int? iepEventCode { get; set; }

    /*  */
    public DateTime? writtenParentalConsentDate { get; set; }

    /* An unordered collection of studentProgramAssociationServices.  This association represents the Special Education program(s) that a student participates in or receives services from. The association is an extension of the StudentProgramAssociation particular for Special Education programs. */
    public List<StudentProgramAssociationService> services { get; set; }

    /* An unordered collection of studentSpecialEducationProgramAssociationServiceProviders.  This association represents the Special Education program(s) that a student participates in or receives services from. The association is an extension of the StudentProgramAssociation particular for Special Education programs. */
    public List<StudentSpecialEducationProgramAssociationServiceProvider> serviceProviders { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
