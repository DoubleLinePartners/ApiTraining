using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class StudentAcademicRecordDiploma {
    /* The type of diploma/credential that is awarded to a student in recognition of his/her completion of the curricular requirements.   */
    public string diplomaType { get; set; }

    /* The month, day, and year on which the student met  graduation requirements and was awarded a diploma.   */
    public DateTime? diplomaAwardDate { get; set; }

    /* The type of diploma/credential that is awarded to a student in recognition of his/her completion of the curricular requirements.  Minimum high school program  Recommended high school program  Distinguished Achievement Program     */
    public string diplomaLevelType { get; set; }

    /* Indicated a student who reached a state&ndash;defined threshold of vocational education and who attained a high school diploma or its recognized state equivalent or GED.   */
    public bool? cteCompleter { get; set; }

    /* The description of diploma given to the student for accomplishments. */
    public string diplomaDescription { get; set; }

    /*  */
    public DateTime? diplomaAwardExpiresDate { get; set; }

    /* The title assigned to the achievement. */
    public string achievementTitle { get; set; }

    /* A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. */
    public string achievementCategoryDescriptor { get; set; }

    /* The system that defines the categories by which an achievement is attributed to the learner. */
    public string achievementCategorySystem { get; set; }

    /* The name of the agent issuing the award. */
    public string issuerName { get; set; }

    /* The Uniform Resource Locator (URL) from which the award was issued. */
    public string issuerOriginURL { get; set; }

    /* The criteria for competency-based completion of the achievement/award. */
    public string criteria { get; set; }

    /* The Uniform Resource Locator (URL) for the unique address of a web page describing the competency-based completion criteria for the achievement/award. */
    public string criteriaURL { get; set; }

    /* A statement or reference describing the evidence that the learner met the criteria for attainment of the achievement. */
    public string evidenceStatement { get; set; }

    /* The Uniform Resource Locator (URL) for the unique address of an image representing an award or badge associated with the achievement. */
    public string imageURL { get; set; }

    }
}
