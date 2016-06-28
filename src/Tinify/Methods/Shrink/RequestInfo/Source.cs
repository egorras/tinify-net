using Newtonsoft.Json;

namespace Tinify.Methods.Shrink.RequestInfo
{
    internal class Source
    {
        public Source(string url)
        {
            Url = url;
        }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
