using Newtonsoft.Json;
using Tinify.Methods.Shrink.RequestInfo;

namespace Tinify.Methods.Shrink
{
    /// <summary>
    /// Container for data used to make shrink request.
    /// </summary>
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
