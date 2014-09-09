using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class StaffIdentificationDocument {
    /* Key for PersonalInformationVerification */
    public string personalInformationVerificationType { get; set; }

    /* A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. */
    public string identificationDocumentUseType { get; set; }

    /* The title of the document given by the issuer. */
    public string documentTitle { get; set; }

    /* The day when the document  expires, if null then never expires. */
    public DateTime? documentExpirationDate { get; set; }

    /* The unique identifier on the issuer's identification system. */
    public string issuerDocumentIdentificationCode { get; set; }

    /* Name of the entity or institution that issued the document. */
    public string issuerName { get; set; }

    /*  */
    public string issuerCountryType { get; set; }

    }
}
