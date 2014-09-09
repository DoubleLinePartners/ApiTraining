using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class EducationContent {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A reference to the related LearningStandard resource. */
    public LearningStandardReference learningStandardReference { get; set; }

    /* A unique identifier for the content. */
    public string contentIdentifier { get; set; }

    /* The URI (typical a URL) pointing to the metadata entry in a LRMI metadata repository, which describes this content item. */
    public string learningResourceMetadataURI { get; set; }

    /* A shortened description for the descriptor. */
    public string shortDescription { get; set; }

    /* The description of the descriptor. */
    public string description { get; set; }

    /* Indicates whether there are additional un-named authors. In a research report, this is often marked by the abbreviation ""et al"". */
    public bool? additionalAuthorsIndicator { get; set; }

    /* The organization credited with publishing the resource. */
    public string publisher { get; set; }

    /* Approximate or typical time it takes to work with or through this learning resource for the typical intended target audience. */
    public string timeRequired { get; set; }

    /* A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. */
    public string interactivityStyleType { get; set; }

    /* A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. */
    public string contentClassType { get; set; }

    /* The URL where the owner specifies permissions for using the resource. */
    public string useRightsURL { get; set; }

    /* The date on which this content was first published. */
    public DateTime? publicationDate { get; set; }

    /* The year at which this content was first published. */
    public int? publicationYear { get; set; }

    /* The version identifier for the content. */
    public string version { get; set; }

    /* An amount that has to be paid or spent to buy or obtain the education content */
    public double? cost { get; set; }

    /* A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. */
    public string costRateType { get; set; }

    /* An unordered collection of educationContentAppropriateGradeLevels.  Materials for students or teachers that can be used for teaching, learning, research and more. Education content includes full courses, course materials, modules, intervention descriptions, textbooks, streaming videos, tests, software and any other tools, materials or techniques used to support access to knowledge. */
    public List<EducationContentAppropriateGradeLevel> appropriateGradeLevels { get; set; }

    /* An unordered collection of educationContentAppropriateSexes.  Materials for students or teachers that can be used for teaching, learning, research and more. Education content includes full courses, course materials, modules, intervention descriptions, textbooks, streaming videos, tests, software and any other tools, materials or techniques used to support access to knowledge. */
    public List<EducationContentAppropriateSex> appropriateSexes { get; set; }

    /* An unordered collection of educationContentAuthors.  Materials for students or teachers that can be used for teaching, learning, research and more. Education content includes full courses, course materials, modules, intervention descriptions, textbooks, streaming videos, tests, software and any other tools, materials or techniques used to support access to knowledge. */
    public List<EducationContentAuthor> authors { get; set; }

    /* An unordered collection of educationContentDerivativeSourceEducationContents.  Materials for students or teachers that can be used for teaching, learning, research and more. Education content includes full courses, course materials, modules, intervention descriptions, textbooks, streaming videos, tests, software and any other tools, materials or techniques used to support access to knowledge. */
    public List<EducationContentDerivativeSourceEducationContent> derivativeSourceEducationContents { get; set; }

    /* An unordered collection of educationContentDerivativeSourceLearningResourceMetadataURIs.  Materials for students or teachers that can be used for teaching, learning, research and more. Education content includes full courses, course materials, modules, intervention descriptions, textbooks, streaming videos, tests, software and any other tools, materials or techniques used to support access to knowledge. */
    public List<EducationContentDerivativeSourceLearningResourceMetadataURI> derivativeSourceLearningResourceMetadataURIs { get; set; }

    /* An unordered collection of educationContentDerivativeSourceURIs.  Materials for students or teachers that can be used for teaching, learning, research and more. Education content includes full courses, course materials, modules, intervention descriptions, textbooks, streaming videos, tests, software and any other tools, materials or techniques used to support access to knowledge. */
    public List<EducationContentDerivativeSourceURI> derivativeSourceURIs { get; set; }

    /* An unordered collection of educationContentLanguages.  Materials for students or teachers that can be used for teaching, learning, research and more. Education content includes full courses, course materials, modules, intervention descriptions, textbooks, streaming videos, tests, software and any other tools, materials or techniques used to support access to knowledge. */
    public List<EducationContentLanguage> languages { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
