namespace EdFi.Rest.Models
{
    public class BulkOperationException
    {
        public string id { get; set; }
        public string uploadFileId { get; set; }
        public string type { get; set; }
        public string element { get; set; }
        public string message { get; set; }
    }
}
