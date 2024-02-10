
namespace Sheenam.Brokers.Files
{
    public interface IFileBroker
    {
        ValueTask<string> SaveFileAsync(MemoryStream memoryStream, string fileName, string uploadsFolder);
    }
}
