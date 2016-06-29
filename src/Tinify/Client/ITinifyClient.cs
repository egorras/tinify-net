using System.Threading.Tasks;
using Tinify.Methods.Shrink;

namespace Tinify.Client
{
    /// <summary>
    /// Tinify API client. Allows you to compress and optimize JPEG and PNG images.
    /// <see cref="https://tinypng.com/developers/reference"/>
    /// </summary>
    public interface ITinifyClient
    {
        /// <summary>
        /// Set API key to use Tinify API.
        /// </summary>
        /// <param name="apiKey">API key.</param>
        void SetApiKey(string apiKey);

        /// <summary>
        /// Compress image.
        /// </summary>
        /// <param name="shrinkRequest">URL to image.</param>
        /// <returns>URL to compressed image.</returns>
        Task<ShrinkResponse> ShrinkAsync(ShrinkRequest shrinkRequest);
    }
}
