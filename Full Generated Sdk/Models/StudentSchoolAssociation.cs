using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class StudentSchoolAssociation {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A reference to the related GraduationPlan resource. */
    public GraduationPlanReference graduationPlanReference { get; set; }

    /* A reference to the related School resource. */
    public SchoolReference schoolReference { get; set; }

    /* A reference to the related SchoolYearType resource. */
    public SchoolYearTypeReference classOfSchoolYearTypeReference { get; set; }

    /* A reference to the related SchoolYearType resource. */
    public SchoolYearTypeReference schoolYearTypeReference { get; set; }

    /* A reference to the related Student resource. */
    public StudentReference studentReference { get; set; }

    /* The month, day, and year on which an individual enters and begins to receive instructional services in a campus.  NEDM: School Entry Date  NEDM: LEA Entry Date   */
    public DateTime? entryDate { get; set; }

    /* The grade level or primary instructional level at which a student enters and receives services in a school or an educational institution during a given academic session.   */
    public string entryGradeLevelDescriptor { get; set; }

    /* A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. */
    public string entryGradeLevelReasonType { get; set; }

    /* A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. */
    public string entryTypeDescriptor { get; set; }

    /* An indicator of whether the student is enrolling to repeat a grade level, either by failure or an agreement to hold the student back. */
    public bool? repeatGradeIndicator { get; set; }

    /* An indication of whether students transferred in or out of the school did so during the school year under the provisions for public school choice in accordance with Title I, Part A, Section 1116.   */
    public bool? schoolChoiceTransfer { get; set; }

    /* The month, day, and year of the first day after the date of an individual''s last attendance at a campus (if known), the day on which an individual graduated, or the date on which it becomes known officially that an individual left school.  NEDM: Exit/Withdraw Date   */
    public DateTime? exitWithdrawDate { get; set; }

    /* A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. */
    public string exitWithdrawTypeDescriptor { get; set; }

    /* A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. */
    public string residencyStatusDescriptor { get; set; }

    /* Indicates if a given enrollment record should be considered the primary record for a student. If omitted, the default is true. */
    public bool? primarySchool { get; set; }

    /* An individual who is a paid employee or works in his or her own business, profession, or farm and at the same time is enrolled in secondary, postsecondary, or adult education. */
    public bool? employedWhileEnrolled { get; set; }

    /*  */
    public string homelessMcKinneyServedIndicator { get; set; }

    /*  */
    public string homelessUnaccompaniedIndicator { get; set; }

    /*  */
    public string sesAppliedIndicator { get; set; }

    /*  */
    public string sesReceivingIndicator { get; set; }

    /*  */
    public string completionDocumentDescriptor { get; set; }

    /*  */
    public string completionDocumentPeriodDescriptor { get; set; }

    /*  */
    public int? totalInstructionalMins { get; set; }

    /*  */
    public DateTime? studentStandardDayEffectiveDate { get; set; }

    /* An unordered collection of studentSchoolAssociationEducationPlans.  This association represents the school in which a student is enrolled. */
    public List<StudentSchoolAssociationEducationPlan> educationPlans { get; set; }

    /* An unordered collection of studentSchoolAssociationFundingStatuses.  This association represents the school in which a student is enrolled. */
    public List<StudentSchoolAssociationFundingStatus> fundingStatuses { get; set; }

    /* An unordered collection of studentSchoolAssociationInstructionalServices.  This association represents the school in which a student is enrolled. */
    public List<StudentSchoolAssociationInstructionalService> instructionalServices { get; set; }

    /* An unordered collection of studentSchoolAssociationSupportServices.  This association represents the school in which a student is enrolled. */
    public List<StudentSchoolAssociationSupportService> supportServices { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
