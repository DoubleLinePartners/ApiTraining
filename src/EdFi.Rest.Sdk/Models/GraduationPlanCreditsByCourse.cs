using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class GraduationPlanCreditsByCourse {
    /* The name of the set of courses */
    public string courseSetName { get; set; }

    /* The value of credits or units of value awarded for the completion of a course. */
    public double? credit { get; set; }

    /* Key for Credit */
    public string creditType { get; set; }

    /* Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. */
    public double? creditConversion { get; set; }

    /* The grade level when the student is planned to take the course. */
    public string gradeLevelDescriptor { get; set; }

    /* An unordered collection of graduationPlanCreditsByCourseCourses.  The total credits required for graduation by taking a specific course, or by taking one or more from a set of courses. */
    public List<GraduationPlanCreditsByCourseCourse> courses { get; set; }

    }
}
