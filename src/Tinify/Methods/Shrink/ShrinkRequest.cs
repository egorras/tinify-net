using Newtonsoft.Json;
using Tinify.Methods.Shrink.RequestInfo;

namespace Tinify.Methods.Shrink
{
    public class ShrinkRequest
    {
        public ShrinkRequest(string sourceUrl)
        {
            Source = new Source(sourceUrl);
        }

        [JsonProperty("source")]
        public Source Source { get; set; }
    }
}
