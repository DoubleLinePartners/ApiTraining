using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class StudentProgramAssociationService {
    /* The ID of the Service Descriptor */
    public string serviceDescriptor { get; set; }

    /*  */
    public bool? primaryIndicator { get; set; }

    /*  */
    public DateTime? serviceBeginDate { get; set; }

    /*  */
    public DateTime? serviceEndDate { get; set; }

    }
}
