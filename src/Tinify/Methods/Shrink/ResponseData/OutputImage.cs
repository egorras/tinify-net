using Newtonsoft.Json;

namespace Tinify.Methods.Shrink.ResponseData
{
    public class OutputImage : Image
    {
        [JsonProperty("width")]
        public double Width { get; set; }

        [JsonProperty("height")]
        public double Height { get; set; }

        [JsonProperty("ratio")]
        public double Ratio { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}