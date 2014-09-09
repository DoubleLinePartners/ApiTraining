using System.Collections.Generic;

namespace EdFi.Rest.Client.Sdk.Models
{
    public class Identity
    {
        public string uniqueId { get; set; }
        public string familyNames { get; set; }
        public string givenNames { get; set; }
        public string birthGender { get; set; }
        public string birthDate { get; set; }
        public int? weight { get; set; }
    }
}
