using System.Threading.Tasks;
using Moq;
using RestSharp;
using RestSharp.Authenticators;
using Tinify.Client;
using Tinify.Methods.Shrink;
using Xunit;

namespace Tinify.Tests.Client
{
    public class TinifyClientTests
    {
        private const string ApiKey = "api_key";

        [Fact]
        internal void Auth_header_should_be_set_on_init()
        {
            var restClient = new Mock<IRestClient>();
            restClient.SetupAllProperties();
            var tinifyClient = new TinifyClient(ApiKey, restClient.Object);
            Assert.IsType(typeof (HttpBasicAuthenticator), restClient.Object.Authenticator);
        }

        [Fact]
        internal void Api_url_should_be_set()
        {
            var restClient = new Mock<IRestClient>();
            restClient.SetupAllProperties();
            var tinifyClient = new TinifyClient(ApiKey, restClient.Object);
            Assert.False(string.IsNullOrEmpty(restClient.Object.BaseUrl.AbsoluteUri));
        }

        [Fact]
        internal async Task Should_return_response_on_call()
        {
            var restClient = new Mock<IRestClient>();
            restClient
                .Setup(r => r.ExecuteTaskAsync<ShrinkResponse>(It.IsAny<IRestRequest>()))
                .Returns(Task.FromResult((IRestResponse<ShrinkResponse>) new RestResponse<ShrinkResponse>
                {
                    Data = new ShrinkResponse
                    {
                        Message = "message"
                    }
                }));

            var tinifyClient = new TinifyClient(ApiKey, restClient.Object);
            var request = new ShrinkRequest("image_url.jpg");
            var response = await tinifyClient.ShrinkAsync(request).ConfigureAwait(false);
            Assert.Equal("message", response.Message);
        }
    }
}
