using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class StudentSpecialEducationProgramAssociationServiceProvider {
    /* A reference to the related Staff resource. */
    public StaffReference staffReference { get; set; }

    /* Primary service provider */
    public bool? primaryProvider { get; set; }

    }
}
