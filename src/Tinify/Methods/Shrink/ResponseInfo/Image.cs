using Newtonsoft.Json;

namespace Tinify.Methods.Shrink.ResponseInfo
{
    public class Image
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
