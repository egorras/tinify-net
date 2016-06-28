using Newtonsoft.Json;
using Tinify.Methods.Shrink.RequestData;
using Xunit;

namespace Tinify.Tests.Methods.Shrink.RequestData
{
    public class RequestTests
    {
        [Fact]
        internal static void Shrink_Request_Serialize_Valid()
        {
            var source = new Request("http://test_url.com");
            var json = JsonConvert.SerializeObject(source);
            Assert.Equal(@"{""source"":{""url"":""http://test_url.com""}}", json);
        }
    }
}