using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class GraduationPlan {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A reference to the related EducationOrganization resource. */
    public EducationOrganizationReference educationOrganizationReference { get; set; }

    /* A reference to the related SchoolYearType resource. */
    public SchoolYearTypeReference graduationSchoolYearTypeReference { get; set; }

    /* A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. */
    public string typeDescriptor { get; set; }

    /* An indicator of whether the graduation plan is tailored for an individual. */
    public bool? individualPlan { get; set; }

    /* The total number of credits required for graduation under this plan. */
    public double? totalRequiredCredit { get; set; }

    /* Key for Credit */
    public string totalRequiredCreditType { get; set; }

    /* Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. */
    public double? totalRequiredCreditConversion { get; set; }

    /* An unordered collection of graduationPlanCreditsByCourses.  This entity is a plan outlining the required credits, credits by subject, credits by course and other criteria required for graduation. A graduation plan may be one or more standard plans defined by an education organization and/or individual plans for some or all students. */
    public List<GraduationPlanCreditsByCourse> creditsByCourses { get; set; }

    /* An unordered collection of graduationPlanCreditsBySubjects.  This entity is a plan outlining the required credits, credits by subject, credits by course and other criteria required for graduation. A graduation plan may be one or more standard plans defined by an education organization and/or individual plans for some or all students. */
    public List<GraduationPlanCreditsBySubject> creditsBySubjects { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
