using System.Threading.Tasks;
using Moq;
using RestSharp;
using RestSharp.Authenticators;
using Xunit;

namespace Tinify
{
    public class TinifyClientTests
    {
        private const string ApiKey = "api_key";

        [Fact]
        internal void Auth_header_should_be_set()
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
                .Setup(r => r.ExecuteTaskAsync<Methods.Shrink.Response>(It.IsAny<IRestRequest>()))
                .Returns(Task.FromResult((IRestResponse<Methods.Shrink.Response>) new RestResponse<Methods.Shrink.Response>
                {
                    Data = new Methods.Shrink.Response
                    {
                        Message = "message"
                    }
                }));

            var tinifyClient = new TinifyClient(ApiKey, restClient.Object);
            var response = await tinifyClient.ShrinkAsync("image_url.jpg").ConfigureAwait(false);
            Assert.Equal("message", response.Message);
        }
    }
}
