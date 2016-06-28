using Newtonsoft.Json;
using Tinify.Methods.Shrink.ResponseData;
using Xunit;

namespace Tinify.Tests.Methods.Shrink.ResponseData
{
    public class OutputImageTests
    {
        [Fact]
        internal static void Shrink_Response_OutputImage_Deserialize_Valid()
        {
            var json = @"{""size"":1,""type"":""2"",""width"":3,""height"":4,""ratio"":5,""url"":""6""}";
            var outputImage = JsonConvert.DeserializeObject<OutputImage>(json);
            Assert.Equal(1, outputImage.Size);
            Assert.Equal("2", outputImage.Type);
            Assert.Equal(3, outputImage.Width);
            Assert.Equal(4, outputImage.Height);
            Assert.Equal(5, outputImage.Ratio);
            Assert.Equal("6", outputImage.Url);
        }
    }
}
