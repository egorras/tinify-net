namespace Tinify
{
    public interface ITinifyClient
    {
        Methods.Shrink.ResponseData.Response Shrink(string imageUrl);
    }
}
