using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class StaffCompensation {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A unique alpha-numeric code assigned to a staff. */
    public string staffUniqueId { get; set; }

    /*  */
    public int? educationOrganizationId { get; set; }

    /*  */
    public string employmentStatusDescriptor { get; set; }

    /*  */
    public DateTime? hireDate { get; set; }

    /*  */
    public int? percentWorked { get; set; }

    /*  */
    public int? paidMonths { get; set; }

    /*  */
    public int? paidDays { get; set; }

    /*  */
    public int? careerLadder { get; set; }

    /*  */
    public int? careerLadderExpiryYear { get; set; }

    /*  */
    public int? numberSupervised { get; set; }

    /*  */
    public double? stateSalary { get; set; }

    /*  */
    public double? stateIncrement { get; set; }

    /*  */
    public double? totalBEPSalary { get; set; }

    /*  */
    public double? clSupplement { get; set; }

    /*  */
    public double? extContract { get; set; }

    /*  */
    public double? totalStateSalary { get; set; }

    /*  */
    public double? fromFederal { get; set; }

    /*  */
    public double? fromLocal { get; set; }

    /*  */
    public double? totalSalary { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
