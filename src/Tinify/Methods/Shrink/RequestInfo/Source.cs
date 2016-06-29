using Newtonsoft.Json;

namespace Tinify.Methods.Shrink.RequestInfo
{
    public class Source
    {
        public Source(string url)
        {
            Url = url;
        }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
