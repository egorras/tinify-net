using System.Threading.Tasks;

namespace Tinify
{
    public interface ITinifyClient
    {
        Task<Methods.Shrink.Response> ShrinkAsync(string imageUrl);
    }
}
