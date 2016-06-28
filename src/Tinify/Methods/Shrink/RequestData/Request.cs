using Newtonsoft.Json;

namespace Tinify.Methods.Shrink.RequestData
{
    internal class Request
    {
        public Request(string sourceUrl)
        {
            Source = new Source(sourceUrl);
        }

        [JsonProperty("source")]
        public Source Source { get; set; }
    }
}
