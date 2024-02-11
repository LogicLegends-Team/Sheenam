
namespace Sheenam.Services.Processings.File
{
    public interface IFileProcessingService
    {
        string DeleteImageFile(string imageName);
        ValueTask<string> UploadFileAsync(MemoryStream memoryStream, string fileName);
    }
}