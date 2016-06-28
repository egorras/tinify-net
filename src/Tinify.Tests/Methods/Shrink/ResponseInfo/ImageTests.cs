using Newtonsoft.Json;
using Tinify.Methods.Shrink.ResponseInfo;
using Xunit;

namespace Tinify.Tests.Methods.Shrink.ResponseInfo
{
    public class ImageTests
    {
        [Fact]
        internal static void Shrink_Response_Image_Deserialize_Valid()
        {
            var json = @"{""size"":1,""type"":""2""}";
            var image = JsonConvert.DeserializeObject<Image>(json);
            Assert.Equal(1, image.Size);
            Assert.Equal("2", image.Type);
        }
    }
}
