using System;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Authenticators;
using Tinify.Methods.Shrink;
using Tinify.Serializers;

namespace Tinify.Client
{
    /// <summary>
    /// Tinify API client. Allows you to compress and optimize JPEG and PNG images.
    /// <see cref="https://tinypng.com/developers/reference"/>
    /// </summary>
    public class TinifyClient : ITinifyClient
    {
        private readonly IRestClient restClient;

        private const string ApiUrl = "https://api.tinify.com";
        private const string ShrinkUrl = "/shrink";

        /// <summary>
        /// Initialize Tinify API client.
        /// </summary>
        /// <param name="apiKey">API key.</param>
        public TinifyClient(string apiKey)
            : this(apiKey, new RestClient())
        {
        }

        internal TinifyClient(string apiKey, IRestClient restClient)
        {
            this.restClient = restClient;

            SetupRestClient();
            SetApiKey(apiKey);
        }

        /// <summary>
        /// Set API key to use Tinify API.
        /// </summary>
        /// <param name="apiKey">API key.</param>
        public void SetApiKey(string apiKey)
        {
            restClient.Authenticator = new HttpBasicAuthenticator("api", apiKey);
        }

        /// <summary>
        /// Compress image.
        /// </summary>
        /// <param name="shrinkRequest">URL to image.</param>
        /// <returns>URL to compressed image.</returns>
        public async Task<ShrinkResponse> ShrinkAsync(ShrinkRequest shrinkRequest)
        {
            var request = new RestRequest(ShrinkUrl, Method.POST)
            {
                RequestFormat = DataFormat.Json,
                JsonSerializer = NewtonsoftJsonSerializer.Default,
                OnBeforeDeserialization = r => { r.ContentType = "application/json"; }
            };
            request.AddJsonBody(shrinkRequest);
            var response = await restClient.ExecuteTaskAsync<ShrinkResponse>(request).ConfigureAwait(false);
            return response.Data;
        }

        private void SetupRestClient()
        {
            restClient.BaseUrl = new Uri(ApiUrl);
        }
    }
}
