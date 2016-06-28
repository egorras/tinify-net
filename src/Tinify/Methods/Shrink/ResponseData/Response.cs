using Newtonsoft.Json;

namespace Tinify.Methods.Shrink.ResponseData
{
    public class Response
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
