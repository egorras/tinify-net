using Newtonsoft.Json;
using Xunit;

namespace Tinify.Methods.Shrink.ResponseData
{
    public class ResponseTests
    {
        [Fact]
        internal static void Shrink_Response_Deserialize_Valid()
        {
            var json = @"{""input"":{},""output"":{},""error"":""1"",""message"":""2""}";
            var response = JsonConvert.DeserializeObject<Response>(json);
            Assert.NotNull(response.Input);
            Assert.NotNull(response.Output);
            Assert.Equal("1", response.Error);
            Assert.Equal("2", response.Message);
        }
    }
}
