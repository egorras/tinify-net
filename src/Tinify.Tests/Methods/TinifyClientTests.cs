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
    }
}
