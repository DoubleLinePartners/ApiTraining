using System;
using System.Linq;
using RestSharp;

namespace EdFi.Rest.Sdk
{
    public class BearerTokenAuthenticator : IAuthenticator
    {
        private string bearerToken;

        public BearerTokenAuthenticator(ITokenRetriever tokenRetriever)
        {
            UpdateToken(tokenRetriever);
        }

        public void UpdateToken(ITokenRetriever tokenRetriever)
        {
            bearerToken = tokenRetriever.ObtainNewBearerToken();
        }

        public void Authenticate(IRestClient client, IRestRequest request)
        {
            // confirm bearer token is not already there -- implicit IAuthenticator requirement
            if (!request.Parameters.Any(p => p.Name.Equals("Authorization", StringComparison.OrdinalIgnoreCase)))
            {
                request.AddParameter("Authorization", "Bearer " + bearerToken, ParameterType.HttpHeader);
            }
        }
    }
}
