using System;
using System.Threading.Tasks;
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
        private const string ShrinkUrl = "/shrink";

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

        public async Task<Methods.Shrink.Response> ShrinkAsync(string imageUrl)
        {
            var requestData = new Methods.Shrink.Request(imageUrl);
            var request = new RestRequest(ShrinkUrl, Method.POST)
            {
                RequestFormat = DataFormat.Json,
                JsonSerializer = NewtonsoftJsonSerializer.Default,
                OnBeforeDeserialization = r => { r.ContentType = "application/json"; }
            };
            request.AddJsonBody(requestData);
            var response = await restClient.ExecuteTaskAsync<Methods.Shrink.Response>(request).ConfigureAwait(false);
            return response.Data;
        }

        private void SetupRestClient()
        {
            restClient.BaseUrl = new Uri(ApiUrl);
            restClient.Authenticator = new HttpBasicAuthenticator("api", apiKey);
        }
    }
}
