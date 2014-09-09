using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class Cohort {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A reference to the related EducationOrganization resource. */
    public EducationOrganizationReference educationOrganizationReference { get; set; }

    /* The name or ID for the cohort.   */
    public string identifier { get; set; }

    /* The description of he cohort and its purpose.   */
    public string description { get; set; }

    /* The type of the cohort (academic intervention, attendance intervention, discipline intervention, breakout session, etc.)   */
    public string type { get; set; }

    /* The scope of cohort (e.g., campus, district, classroom, etc.)   */
    public string scopeType { get; set; }

    /* The subject for an academic intervention (e.g., science, mathematics, etc.)   */
    public string academicSubjectDescriptor { get; set; }

    /* An unordered collection of cohortPrograms.  This entity represents any type of list of designated students for tracking, analysis or intervention. */
    public List<CohortProgram> programs { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
