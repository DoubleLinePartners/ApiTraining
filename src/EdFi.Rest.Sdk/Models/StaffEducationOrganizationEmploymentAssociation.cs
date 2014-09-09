using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class StaffEducationOrganizationEmploymentAssociation {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A reference to the related EducationOrganization resource. */
    public EducationOrganizationReference educationOrganizationReference { get; set; }

    /* A reference to the related Staff resource. */
    public StaffReference staffReference { get; set; }

    /* A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. */
    public string employmentStatusDescriptor { get; set; }

    /* The month, day, and year on which a contract between an individual and a governing authority specifies that employment is to begin (or the date on which the agreement is made valid).  NEDM: Contract Beginning Date */
    public DateTime? hireDate { get; set; }

    /* The month, day, and year on which a contract between an individual and a governing authority ends or is terminated under the provisions of the contract (or the date on which the agreement is made invalid).  NEDM: Contract Ending Date */
    public DateTime? endDate { get; set; }

    /* Type of employment separation; for example:  Voluntary separation  Involuntary separation  Mutual agreement  Other */
    public string separationType { get; set; }

    /* A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. */
    public string separationReasonDescriptor { get; set; }

    /* The department or suborganization the employee/contractor is associated with in the Education Organization. */
    public string department { get; set; }

    /* The ratio between the hours of work expected in a position and the hours of work normally expected in a full-time position in the same setting. */
    public double? fullTimeEquivalency { get; set; }

    /* Date at which the staff member was made an official offer for this employment. */
    public DateTime? offerDate { get; set; }

    /* Hourly wage associated with the employment position being reported. */
    public double? hourlyWage { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
