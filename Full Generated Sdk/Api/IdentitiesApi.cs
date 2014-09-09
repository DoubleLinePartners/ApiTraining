using System.Collections.Generic;
using EdFi.Rest.Client.Sdk.Models;
using RestSharp;
using System;

namespace EdFi.Rest.Api
{
    public class IdentitiesApi
    {
        private readonly IRestClient client;

        public IdentitiesApi(IRestClient client)
        {
            this.client = client;
        }

        public IRestResponse<List<Identity>> GetIdentityByExample(Identity identity)
        {
            var request = new RestRequest("/identities", Method.GET);
            request.RequestFormat = DataFormat.Json;

            if (!string.IsNullOrEmpty(identity.familyNames))
                request.AddParameter("familyNames", identity.familyNames);

            if (!string.IsNullOrEmpty(identity.givenNames))
                request.AddParameter("givenNames", identity.givenNames);

            if (!string.IsNullOrEmpty(identity.birthGender))
                request.AddParameter("birthGender", identity.birthGender);

            if (!string.IsNullOrEmpty(identity.birthDate))
                request.AddParameter("birthDate", identity.birthDate);

            return client.Execute<List<Identity>>(request);
        }

        public IRestResponse<Identity> PostIdentity(Identity body)
        {
            var request = new RestRequest("/identities", Method.POST);
            request.RequestFormat = DataFormat.Json;

            // verify required params are set
            if (body == null)
            {
                throw new ArgumentException("API method call is missing required parameters");
            }
            request.AddBody(body);

            return client.Execute<Identity>(request);
        }

        public IRestResponse<Identity> GetIdentitiesById(string id)
        {
            var request = new RestRequest("/identities/{id}", Method.GET);
            request.RequestFormat = DataFormat.Json;

            request.AddUrlSegment("id", id);
            // verify required params are set
            if (id == null)
            {
                throw new ArgumentException("API method call is missing required parameters");
            }

            return client.Execute<Identity>(request);
        }
    }
}
