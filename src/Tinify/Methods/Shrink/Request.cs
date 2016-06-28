using Newtonsoft.Json;
using Tinify.Methods.Shrink.RequestInfo;

namespace Tinify.Methods.Shrink
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
