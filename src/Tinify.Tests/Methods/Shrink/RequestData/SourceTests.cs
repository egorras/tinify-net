using Newtonsoft.Json;
using Xunit;
using Tinify.Methods.Shrink.RequestData;

namespace Tinify.Tests.Methods.Shrink.RequestData
{
    public class SourceTests
    {
        [Fact]
        internal static void Shrink_Request_Source_Serialize_Valid()
        {
            var source = new Source("http://test_url.com");
            var json = JsonConvert.SerializeObject(source);
            Assert.Equal(@"{""url"":""http://test_url.com""}", json);
        }
    }
}
