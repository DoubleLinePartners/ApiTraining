using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class Section {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A reference to the related ClassPeriod resource. */
    public ClassPeriodReference classPeriodReference { get; set; }

    /* A reference to the related CourseOffering resource. */
    public CourseOfferingReference courseOfferingReference { get; set; }

    /* A reference to the related Location resource. */
    public LocationReference locationReference { get; set; }

    /* A reference to the related School resource. */
    public SchoolReference schoolReference { get; set; }

    /* A reference to the related Session resource. */
    public SessionReference sessionReference { get; set; }

    /* A unique identifier for the section, that is defined for a campus by the classroom, the subjects taught, and the instructors that are assigned.  NEDM: Unique Course Code   */
    public string uniqueSectionCode { get; set; }

    /* When a section is part of a sequence of parts for a course, the number if the sequence.  If the course has only onle part, the value of this section attribute should be 1.   */
    public int? sequenceOfCourse { get; set; }

    /* The setting in which a child receives education and related services; for example:  Center-based instruction  Home-based instruction  Hospital class  Mainstream  Residential care and treatment facility  ....     */
    public string educationalEnvironmentType { get; set; }

    /* The media through which teachers provide instruction to students and students and teachers communicate about instructional matters; for example:  Technology-based instruction in classroom  Correspondence instruction  Face-to-face instruction  Virtual/On-line Distance learning  Center-based instruction  ...   */
    public string mediumOfInstructionType { get; set; }

    /* The population for which the course was designed; for example:  Bilingual students  Remedial education students  Gifted and talented students  Career and Technical Education students  Special education students  ....   */
    public string populationServedType { get; set; }

    /* The type of credits or units of value awarded for the completion of a course.   */
    public string availableCreditType { get; set; }

    /* Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. */
    public double? availableCreditConversion { get; set; }

    /* A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. */
    public string instructionLanguageDescriptor { get; set; }

    /* Credits or units of value awarded for the completion of a course. */
    public double? availableCredit { get; set; }

    /* An unordered collection of sectionCharacteristics.  This educational entity represents a setting in which organized instruction of course content is provided to one or more students for a given period of time. A course may be offered to more than one class/section. Instruction, provided by one or more teachers or other staff members, may be delivered in person or via a different medium. */
    public List<SectionCharacteristic> characteristics { get; set; }

    /* An unordered collection of sectionPrograms.  This educational entity represents a setting in which organized instruction of course content is provided to one or more students for a given period of time. A course may be offered to more than one class/section. Instruction, provided by one or more teachers or other staff members, may be delivered in person or via a different medium. */
    public List<SectionProgram> programs { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
