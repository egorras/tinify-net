using System;
using RestSharp;
using RestSharp.Authenticators;

namespace Tinify
{
    /// <summary>
    /// Tinify API client. Allows you to compress and optimize JPEG and PNG images.
    /// <see cref="https://tinypng.com/developers/reference"/>
    /// </summary>
    public class TinifyClient : ITinifyClient
    {
        private readonly IRestClient restClient;
        private readonly string apiKey;

        private const string ApiUrl = "https://api.tinify.com";

        public TinifyClient(string apiKey)
            : this(apiKey, new RestClient())
        {
        }

        internal TinifyClient(string apiKey, IRestClient restClient)
        {
            this.apiKey = apiKey;
            this.restClient = restClient;

            SetupRestClient();
        }

        public Methods.Shrink.ResponseData.Response Shrink(string imageUrl)
        {
            throw new NotImplementedException();
        }

        private void SetupRestClient()
        {
            restClient.BaseUrl = new Uri(ApiUrl);
            restClient.Authenticator = new HttpBasicAuthenticator("api", apiKey);
        }
    }
}
