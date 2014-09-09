using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class GradebookEntry {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A reference to the related GradingPeriod resource. */
    public GradingPeriodReference gradingPeriodReference { get; set; }

    /* A reference to the related Section resource. */
    public SectionReference sectionReference { get; set; }

    /* The name or title of the activity to be recorded in the gradebook entry. */
    public string title { get; set; }

    /* The date the assignment, homework, or assessment was assigned or executed. */
    public DateTime? dateAssigned { get; set; }

    /* The description of the descriptor. */
    public string description { get; set; }

    /* A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. */
    public string type { get; set; }

    /* An unordered collection of gradebookEntryLearningObjectives.  This entity represents a teacher’s assignment, homework or classroom assessment to be recorded in a gradebook. */
    public List<GradebookEntryLearningObjective> learningObjectives { get; set; }

    /* An unordered collection of gradebookEntryLearningStandards.  This entity represents a teacher’s assignment, homework or classroom assessment to be recorded in a gradebook. */
    public List<GradebookEntryLearningStandard> learningStandards { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
