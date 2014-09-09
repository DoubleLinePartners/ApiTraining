﻿using EdFi.Rest.Models;
using RestSharp;
using System.Collections.Generic;

namespace EdFi.Rest.Api
{
    public class BulkOperationExceptionsApi
    {
        private readonly IRestClient client;

        public BulkOperationExceptionsApi(IRestClient client)
        {
            this.client = client;
        }

        public IRestResponse<List<BulkOperationException>> GetBulkOperationExceptions(string bulkOperationId, string fileUploadId, int? limit, int? offset)
        {
            var request = new RestRequest("/bulkOperations/{id}/exceptions/{fileUploadId}", Method.GET);
            request.RequestFormat = DataFormat.Json;

            request.AddUrlSegment("id", bulkOperationId);
            request.AddUrlSegment("fileUploadId", fileUploadId);

            if (offset != null){
              request.AddParameter("offset", offset);
		    }
            if (limit != null){
              request.AddParameter("limit", limit);
		    }

            return client.Execute<List<BulkOperationException>>(request);
        }
    }
}
