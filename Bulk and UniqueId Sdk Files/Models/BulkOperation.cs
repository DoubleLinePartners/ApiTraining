using System.Collections.Generic;

namespace EdFi.Rest.Models
{
    public class BulkOperation
    {
        public string id { get; set; }
        public List<UploadFile> uploadFiles { get; set; }
        public string status { get; set; }
    }
}
