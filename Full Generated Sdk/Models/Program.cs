using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class Program {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A reference to the related EducationOrganization resource. */
    public EducationOrganizationReference educationOrganizationReference { get; set; }

    /* Key for Program */
    public string type { get; set; }

    /* The formal name of the program of instruction, training, services or benefits available through federal, state, or local agencies. */
    public string name { get; set; }

    /* A unique number or alphanumeric code assigned to a program by a school, school system, a state, or other agency or entity. */
    public string programId { get; set; }

    /* Key for ProgramSponsor */
    public string sponsorType { get; set; }

    /* An unordered collection of programCharacteristics.  This entity represents any program designed to work in conjunction with, or as a supplement to, the main academic program. Programs may provide instruction, training, services or benefits through federal, state or local agencies. Programs may also include organized extracurricular activities for students. */
    public List<ProgramCharacteristic> characteristics { get; set; }

    /* An unordered collection of programLearningObjectives.  This entity represents any program designed to work in conjunction with, or as a supplement to, the main academic program. Programs may provide instruction, training, services or benefits through federal, state or local agencies. Programs may also include organized extracurricular activities for students. */
    public List<ProgramLearningObjective> learningObjectives { get; set; }

    /* An unordered collection of programLearningStandards.  This entity represents any program designed to work in conjunction with, or as a supplement to, the main academic program. Programs may provide instruction, training, services or benefits through federal, state or local agencies. Programs may also include organized extracurricular activities for students. */
    public List<ProgramLearningStandard> learningStandards { get; set; }

    /* An unordered collection of programServices.  This entity represents any program designed to work in conjunction with, or as a supplement to, the main academic program. Programs may provide instruction, training, services or benefits through federal, state or local agencies. Programs may also include organized extracurricular activities for students. */
    public List<ProgramService> services { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
