using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class StaffEducationOrganizationAssignmentAssociation {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A reference to the related StaffEducationOrganizationEmploymentAssociation resource. */
    public StaffEducationOrganizationEmploymentAssociationReference employmentStaffEducationOrganizationEmploymentAssociationReference { get; set; }

    /* A reference to the related EducationOrganization resource. */
    public EducationOrganizationReference educationOrganizationReference { get; set; }

    /* A reference to the related Staff resource. */
    public StaffReference staffReference { get; set; }

    /* The titles of employment, official status, or rank of education staff.   */
    public string staffClassificationDescriptor { get; set; }

    /* Month, day and year of the start or effective date of a staff member''s employment, contract or relationship with the LEA.   */
    public DateTime? beginDate { get; set; }

    /* The descriptive name of an individual''s position.   */
    public string positionTitle { get; set; }

    /* Month, day and year of the end or termination date of a staff member''s employment, contract or relationship with the LEA.   */
    public DateTime? endDate { get; set; }

    /* Describes whether the assignment is this the staff member&apos;s primary assignment, secondary assignment, etc.. */
    public int? orderOfAssignment { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
