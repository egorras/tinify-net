using Newtonsoft.Json;
using Tinify.Methods.Shrink.ResponseInfo;

namespace Tinify.Methods.Shrink
{
    /// <summary>
    /// Container for deserialized data sent back from Tinify API shrink method.
    /// </summary>
    public class ShrinkResponse
    {
        [JsonProperty("input")]
        public Image Input { get; set; }

        [JsonProperty("output")]
        public OutputImage Output { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
