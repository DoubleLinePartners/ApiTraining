using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class InterventionStudyInterventionEffectiveness {
    /* A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. */
    public string diagnosisDescriptor { get; set; }

    /* Key for PopulationServed */
    public string populationServedType { get; set; }

    /* Key for GradeLevel */
    public string gradeLevelDescriptor { get; set; }

    /* Along a percentile distribution of students, the improvement index represents the change in an average student s percentile rank that is considered to be due to the intervention. */
    public int? improvementIndex { get; set; }

    /* A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. */
    public string interventionEffectivenessRatingType { get; set; }

    }
}
