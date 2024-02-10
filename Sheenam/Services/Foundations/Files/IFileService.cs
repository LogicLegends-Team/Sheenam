namespace Sheenam.Services.Foundations.Files
{
    public interface IFileService
    {
        ValueTask<string> UploadFileAsync(
            MemoryStream memoryStream, 
            string fileName, string uploadsFolder);
    }
}
