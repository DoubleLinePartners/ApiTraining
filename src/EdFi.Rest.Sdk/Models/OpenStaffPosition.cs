using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class OpenStaffPosition {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A reference to the related EducationOrganization resource. */
    public EducationOrganizationReference educationOrganizationReference { get; set; }

    /* A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. */
    public string employmentStatusDescriptor { get; set; }

    /* The position''s title or rank (e.g., Counselor, teacher, etc)   */
    public string staffClassificationDescriptor { get; set; }

    /* The number or identifier assigned to an open staff position, typically a requisition number assigned by Human Resources. */
    public string requisitionNumber { get; set; }

    /* The date the position was posted.   */
    public DateTime? datePosted { get; set; }

    /* The descriptive name of an individual''s position.   */
    public string positionTitle { get; set; }

    /* A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. */
    public string programAssignmentDescriptor { get; set; }

    /* The date the posting was removed or filled.   */
    public DateTime? datePostingRemoved { get; set; }

    /* Indication of whether the position was filled or retired without filling.   */
    public string postingResultType { get; set; }

    /* An unordered collection of openStaffPositionAcademicSubjects.  This entity represents an open staff position that the education organization is seeking to fill. */
    public List<OpenStaffPositionAcademicSubject> academicSubjects { get; set; }

    /* An unordered collection of openStaffPositionInstructionalGradeLevels.  This entity represents an open staff position that the education organization is seeking to fill. */
    public List<OpenStaffPositionInstructionalGradeLevel> instructionalGradeLevels { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
