using System.Threading.Tasks;
using Tinify.Methods.Shrink;

namespace Tinify
{
    public interface ITinifyClient
    {
        Task<ShrinkResponse> ShrinkAsync(ShrinkRequest shrinkRequest);
    }
}
