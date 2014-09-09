using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class StudentAcademicRecordRecognition {
    /* The nature of recognition given to the student for accomplishments in a co-curricular, or extra-curricular activity. */
    public string recognitionType { get; set; }

    /* A description of the type of academic distinctions earned by or awarded to the individual. */
    public string recognitionDescription { get; set; }

    /* The date the recognition was awarded or earned. */
    public DateTime? recognitionAwardDate { get; set; }

    /*  */
    public DateTime? recognitionAwardExpiresDate { get; set; }

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
