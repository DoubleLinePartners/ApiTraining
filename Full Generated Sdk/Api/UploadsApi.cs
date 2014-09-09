using System;
using EdFi.Rest.Models;
using RestSharp;

namespace EdFi.Rest.Api
{
    public class UploadsApi
    {
        private readonly IRestClient client;

        public UploadsApi(IRestClient client)
        {
            this.client = client;
        }

        public IRestResponse<Upload> PostUploads(Upload upload)
        {
            var request = new RestRequest("/uploads/{uploadId}/chunk", Method.POST);
            
            request.AddUrlSegment("uploadId", upload.id);
            request.AddParameter("offset", upload.offset.ToString(), ParameterType.QueryString);
            request.AddParameter("size", upload.size.ToString(), ParameterType.QueryString);
            request.AddFile(upload.id, upload.fileBytes, upload.id);

            // verify required params are set
            if (upload.fileBytes == null)
            {
                throw new ArgumentException("API method call is missing required parameters");
            }

            return client.Execute<Upload>(request);
        }

        public IRestResponse<Upload> CommitUploads(Upload upload)
        {
            var request = new RestRequest("/uploads/{uploadId}/commit", Method.POST);

            request.AddUrlSegment("uploadId", upload.id);

            return client.Execute<Upload>(request);
        }
    }
}
