using Sheenam.Models.Foundations.ImageMetadatas;

namespace Sheenam.Services.Orchestrations.Images
{
    public interface IImageOrchestrationService
    {
        ValueTask<ImageMetadata> RemoveImageFileByIdAsync(Guid id);
        ValueTask<string> StoreImageAsync(MemoryStream memoryStream, string extension, Guid homeId);
    }
}