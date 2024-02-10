namespace Sheenam.Services.Processings.File
{
    public interface IFileProcessingService
    {
        ValueTask<string> UploadFileAsync(MemoryStream memoryStream, string fileName);
    }
}